namespace Restaurants.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Microsoft.AspNet.Identity;
    using Models;
    using Restaurants.Models;

    [RoutePrefix("api/restaurants")]
    public class RestaurantController : BaseApiController
    {
        //GET /api/restaurants?townId={townId}
        [HttpGet]
        public IHttpActionResult GetRestaurantsByTown([FromUri] int townId)
        {
            var restaurants = this.Data.Restaurants
                .Where(r => r.TownId == townId)
                .OrderBy(r => r.Name)
                .Select(r => new
                {
                    r.Id,
                    r.Name,
                    rating = r.Ratings,
                    town = new
                    {
                       id = r.TownId,
                       name = this.Data.Towns
                        .Where(t => t.Id == r.TownId)
                        .Select(t => t.Name)
                    }
                });

            //if (restaurants.Any())
            //{
            //    return this.NotFound();
            //}
            return this.Ok(restaurants);
        }


        //POST /api/restaurants
        [HttpPost]
        public IHttpActionResult CreateRestaurant([FromBody]CreateRestaurantBindingModel model)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            if (loggedUserId == null)
            {
                return this.Unauthorized();
            }

            if (model == null)
            {
                return this.BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var restaurant = new Restaurant()
            {
                Name = model.Name,
                TownId = model.TownId,
                OwnerId = loggedUserId
            };

           
            this.Data.Restaurants.Add(restaurant);
            this.Data.SaveChanges();


            return this.CreatedAtRoute(
                "DefaultApi",
                new { id = restaurant.Id },
                new { id = restaurant.Id, name = restaurant.Name, 
                    town = new{ id = restaurant.TownId, name = this.Data.Towns.Where(t => t.Id == restaurant.TownId).Select(t => t.Name)}});
        }

        // POST /api/restaurants/{id}/rate
        [HttpPost]
        [Route("{id}/rate")]
        public IHttpActionResult RateRestaurant(int id, [FromBody] RateRestaurantBindingModel rate)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            var user = this.Data.Users.Find(loggedUserId);

            if (user == null)
            {
                return this.Unauthorized();
            }

            if (rate == null)
            {
                return this.BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var newRate = new Rating()
            {
                Stars = rate.Rate,
                RestaurantId = id,
                UserId = loggedUserId
            };

            var restaurant = this.Data.Restaurants.FirstOrDefault(r => r.Id == id);

            if (restaurant == null)
            {
                return this.BadRequest();
            }

            if (restaurant.OwnerId == newRate.UserId)
            {
                return this.BadRequest();
            }

            restaurant.Ratings.Add(newRate);
            this.Data.SaveChanges();

            return this.Ok();
        }

        // GET /api/restaurants/{id}/meals
        [Route("{id}/meals")]
        public IHttpActionResult GetMeals(int id)
        {
            var restaurant = this.Data.Restaurants.FirstOrDefault(r => r.Id == id);

            if (restaurant == null)
            {
                return this.NotFound();
            }

            var meals = restaurant.Meals
                .OrderBy(rm => rm.TypeId)
                .Select(rm => new
                {
                    rm.Id,
                    rm.Name,
                    rm.Price,
                    type = this.Data.MealTypes
                        .Where(m => m.Id == rm.TypeId)
                        .Select(m => m.Name).First()
                });

            return this.Ok(meals);
        }

    }
}

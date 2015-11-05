namespace Restaurants.Services.Models
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Controllers;
    using Microsoft.AspNet.Identity;
    using Restaurants.Models;

    [RoutePrefix("api/meals")]
    public class MealsController : BaseApiController
    {
        [HttpPost]
        public IHttpActionResult AddMeal([FromBody] AddMealBindingModel model)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            var user = this.Data.Users.Find(loggedUserId);

            var restaurant = this.Data.Restaurants.FirstOrDefault(r => r.Id == model.RestaurantId);

            if (user == null)
            {
                return this.BadRequest();
            }

            if (restaurant == null)
            {
                return this.BadRequest();
            }

            if (model == null)
            {
                return this.BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (user.Id != restaurant.OwnerId)
            {
                return this.BadRequest();
            }

            var meal = new Meal()
            {
                Name = model.Name,
                Price = model.Price,
                RestaurantId = model.RestaurantId,
                TypeId = model.TypeId
            };

            restaurant.Meals.Add(meal);
            this.Data.SaveChanges();

            return this.CreatedAtRoute(
                "DefaultApi",
                new {id = meal.Id},
                new
                {
                    id = meal.Id,
                    name = meal.Name,
                    price = meal.Price,
                    type = this.Data.MealTypes
                        .Where(mt => mt.Id == meal.TypeId)
                        .Select(mt => mt.Name).First()
                });
        }

       // PUT /api/meals/{id}
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult EditMeal(int id, EditMealBindingModel model)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            var user = this.Data.Users.Find(loggedUserId);

            var meal = this.Data.Meals.FirstOrDefault(m => m.Id == id);

            if (meal == null)
            {
                return this.NotFound();
            }

            if (user.Id != meal.Restaurant.OwnerId)
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

            if (!this.Data.MealTypes.Any(m => m.Id == model.TypeId))
            {
                return this.BadRequest();
            }
            meal.Name = model.Name;
            meal.Price = model.Price;
            meal.TypeId = model.TypeId;

            this.Data.SaveChanges();

            return this.CreatedAtRoute(
                "DefaultApi",
                new { id = meal.Id },
                new GetMealsViewModel()
                {
                    Id = meal.Id,
                    Name = meal.Name,
                    Price = meal.Price,
                    Type = this.Data.MealTypes
                        .Where(mt => mt.Id == meal.TypeId)
                        .Select(mt => mt.Name).First()
                });
        }

        //DELETE /api/meals/{id}
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteMeal(int id)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            var user = this.Data.Users.Find(loggedUserId);

            var meal = this.Data.Meals.Find(id);

            if (meal == null)
            {
                return this.NotFound();
            }

            if (meal.Restaurant.OwnerId != user.Id)
            {
                return this.Unauthorized();
            }

            this.Data.Meals.Remove(meal);
            this.Data.SaveChanges();

            return this.Ok(new
            {
                message = string.Format("Meal #{0} deleted.", meal.Id)
            });
        }

        //POST /api/meals/{id}/order

        [HttpPost]
        [Route("{id}/order")]
        public IHttpActionResult CreateOrder(int id, CreateOrderBindingModel model)
        {
            var loggedUserId = this.User.Identity.GetUserId();
            var user = this.Data.Users.Find(loggedUserId);

            var meal = this.Data.Meals.Find(id);

            if (meal == null)
            {
                return this.NotFound();
            }

            if (user == null)
            {
                return this.Unauthorized();
            }

            var order = new Order()
            {
                MealId = id,
                Quantity = model.Quantity,
                UserId = user.Id,
                OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), model.OrderStatus),
                CreatedOn = DateTime.Now
            };

            this.Data.Orders.Add(order);

            return this.Ok();


        }
    }
}

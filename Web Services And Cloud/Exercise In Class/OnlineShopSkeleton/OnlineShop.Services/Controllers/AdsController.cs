using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services.Controllers
{
    using System.Net;
    using System.Web.Http;
    using Microsoft.AspNet.Identity;
    using Models;
    using OnlineShop.Models;

    [Authorize]
    [RoutePrefix("api/ads")]
    public class AdsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetAds()
        {
            var ads = this.Data.Ads
                .Where(a => a.Status == AdStatus.Open)
                .OrderByDescending(a => a.Type.Index)
                .ThenBy(a => a.PostedOn)
                .Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.Description,
                    a.Price,
                    a.OwnerId,
                    a.Owner.UserName,
                    TypeName = a.Type.Name,
                    a.PostedOn,
                    Categories = a.Categories
                        .Select(c => new
                        {
                            c.Id,
                            c.Name
                        })
                });
            return this.Ok(ads);
        }

        [HttpPost]
        public IHttpActionResult CreateAd(CreateAdBindingModel model)
        {
            string loggedUserId = this.User.Identity.GetUserId();

            if (loggedUserId == null)
            {
                return this.Unauthorized();
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (!model.Categories.Any() && model.Categories.Count() > 3)
            {
                return this.BadRequest("Categories count must be in range [1...3]");
            }


            var ad = new Ad()
            {
                Name = model.Name,
                Description = model.Description,
                TypeId = model.TypeId,
                Price = model.Price,
                Categories = new HashSet<Category>(),
                PostedOn = DateTime.Now,
                OwnerId = loggedUserId
            };

            foreach (var categoryId in model.Categories)
            {
                var isFind = this.Data.Categories.Find(categoryId);
                if (isFind == null)
                {
                    return this.BadRequest();
                }
                ad.Categories.Add(isFind);
            }

            this.Data.Ads.Add(ad);
            this.Data.SaveChanges();

            var result = this.Data.Ads
                .Where(a => a.Id == ad.Id)
                .Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.Description,
                    a.Price,
                    Owner = new
                    {
                        a.OwnerId,
                        a.Owner.UserName
                    },
                    TypeName = a.Type.Name,
                    a.PostedOn,
                    Categories = a.Categories
                        .Select(c => c.Name)
                })
                .FirstOrDefault();
            return this.Ok(result);
        }
    }
}
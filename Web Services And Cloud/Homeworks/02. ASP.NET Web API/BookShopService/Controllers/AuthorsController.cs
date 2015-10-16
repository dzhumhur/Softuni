using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookShopService.Controllers
{
    using BookShop.Data;
    using BookShop.Models;

    public class AuthorsController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            var context = new BooksShopContext();
            var author = context.Authors
                .Where(a => a.Id == id)
                .Select(a => new
                {
                    a.Id,
                    a.FirstName,
                    a.LastName
                });
            return this.Ok(author);
        }

        public void Post([FromBody]Author author)
        {
            var context = new BooksShopContext();
            context.Authors.Add(new Author()
            {
                FirstName = author.FirstName,
                LastName = author.LastName
            });
            context.SaveChanges();
        }
    }
}

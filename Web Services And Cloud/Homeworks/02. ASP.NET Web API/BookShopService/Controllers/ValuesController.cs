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

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var context = new BooksShopContext();
            var author = context.Authors
                .Where(a => a.Id == id)
                .Select(a => "Id: " + a.Id + " - " + a.FirstName + " " + a.LastName );

            return this.Ok(author);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

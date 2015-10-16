using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data;

namespace Twitter.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController() : this(new ApplicationDbContext())
        {
            
        }

        public BaseController(ApplicationDbContext context)
        {
            this.Data = context;
        }

        protected ApplicationDbContext Data { get; set; }
    }
}
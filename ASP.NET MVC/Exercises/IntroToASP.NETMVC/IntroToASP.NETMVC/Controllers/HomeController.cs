using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToASP.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int first, int second)
        {
            int result = first + second;
            ViewBag.Result = result;

            return View();
        }

       
    }
}
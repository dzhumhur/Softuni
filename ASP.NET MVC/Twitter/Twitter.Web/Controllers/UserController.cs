using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Twitter.Models;

namespace Twitter.Web.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        [HttpGet]
        public ActionResult FollowUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FollowUser(string email)
        {
            var loggedUserId = User.Identity.GetUserId();
            var user = this.Data.Users.FirstOrDefault(u => u.Id == loggedUserId);
            var followingUser = this.Data.Users.FirstOrDefault(u => u.Email.Equals(email));
            if (user == null)
            {
                return View("_LoginPartial");
            }

            if (followingUser == null )
            {
                return View("Error");
            }

            if (followingUser.Id == user.Id)
            {
                return View("Error");
            }

            user.Following.Add(followingUser);
            followingUser.Followers.Add(user);
            this.Data.SaveChanges();

            ViewBag.Following = followingUser.Email;
            return View();
        }

        public ActionResult FollowingUsers()
        {
            var loggedUserId = User.Identity.GetUserId();
            var user = this.Data.Users.FirstOrDefault(u => u.Id == loggedUserId);

            if (user == null)
            {
                return View("_LoginPartial");
            }

            var followingUsers = user.Following;
            ViewBag.FollowingUsers = followingUsers;
            return View();

        }

        public ActionResult Followers()
        {
            var loggedUserId = User.Identity.GetUserId();
            var user = this.Data.Users.FirstOrDefault(u => u.Id == loggedUserId);

            if (user == null)
            {
                return View("_LoginPartial");
            }

            var followers = user.Followers;
            ViewBag.Followers = followers;
            return View();

        }
    }
}
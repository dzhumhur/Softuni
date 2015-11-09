﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class ApplicationUser : IdentityUser
    {
        private ICollection<ApplicationUser> followers;
        private ICollection<ApplicationUser> following;

        public ApplicationUser()
        {
            this.followers = new HashSet<ApplicationUser>();
            this.following = new HashSet<ApplicationUser>();
        }



        public virtual ICollection<ApplicationUser> Followers
        {
            get { return this.followers; }
            set { this.followers = value; }
        }

        public virtual ICollection<ApplicationUser> Following {
            get { return this.following; }
            set { this.following = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
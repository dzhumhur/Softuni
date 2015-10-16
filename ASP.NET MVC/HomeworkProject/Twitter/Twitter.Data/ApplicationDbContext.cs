using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Twitter.Data.Migrations;
using Twitter.Models;

namespace Twitter.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Reply> Replies { get; set; }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<FavoriteTweet> FavoriteTweets { get; set; }

    }
}

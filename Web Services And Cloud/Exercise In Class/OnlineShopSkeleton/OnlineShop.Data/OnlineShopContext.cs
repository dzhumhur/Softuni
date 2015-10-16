
namespace OnlineShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;


    public class OnlineShopContext : IdentityDbContext<ApplicationUser>
    {
        public OnlineShopContext()
            : base("OnlineShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OnlineShopContext, Configuration>());
        }

        public IDbSet<Ad> Ads { get; set; }

        public IDbSet<AdType> AdTypes { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public static OnlineShopContext Create()
        {
            return new OnlineShopContext();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
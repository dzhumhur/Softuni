namespace BookShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;
    using Models;

    public class BooksShopContext : DbContext
    {
        public BooksShopContext()
            : base("name=BooksShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BooksShopContext, Configuration>());
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public static BooksShopContext Create()
        {
            return new BooksShopContext();
        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
    }
}
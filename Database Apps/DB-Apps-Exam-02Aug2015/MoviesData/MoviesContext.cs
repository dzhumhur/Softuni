namespace MoviesData
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;
    using MoviesModels;

    public class MoviesContext : DbContext
    {
        
        public MoviesContext()
            : base("name=MoviesContext")
        {
            var initializer = new MigrateDatabaseToLatestVersion<MoviesContext, Configuration>();
            Database.SetInitializer(initializer);
        }

        public virtual DbSet<Movies> Movie { get; set; }

        public virtual DbSet<Countries> Country { get; set; }

        public virtual DbSet<Users> User { get; set; }

        public virtual DbSet<Ratings> Rating { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
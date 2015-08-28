namespace MoviesData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesData.MoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "MoviesData.MoviesContext";
        }

        protected override void Seed(MoviesData.MoviesContext context)
        {

        }
    }
}

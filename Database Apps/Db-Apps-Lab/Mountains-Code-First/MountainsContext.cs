namespace Mountains_Code_First
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Migrations;

    public class MountainsContext : DbContext
    {
        public MountainsContext()
            : base("name=MountainsContext")
        {
            var migrationStrategy = new MigrateDatabaseToLatestVersion<MountainsContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
        }

        public virtual DbSet<Country> Countries { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
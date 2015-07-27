using System.Collections.Generic;
using System.Globalization;
using System.IO;
using BookShoop.Models;

namespace BooksShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksShop.Data.BookShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "BooksShop.Data.BookShopContext";
        }

        protected override void Seed(BooksShop.Data.BookShopContext context)
        {

            // Reading Authors from text file and inserts to database
            //StreamReader reader = new StreamReader("../../../authors.txt");

            //var line = reader.ReadLine();
            //string[] fullName = line.Split(' ');

            //while (line != null)
            //{
            //    context.Authors.Add(new Author()
            //    {
            //        FirstName = fullName[0],
            //        LastName = fullName[1]
            //    });

            //    line = reader.ReadLine();
            //    if (line != null)
            //    {
            //        fullName = line.Split(' ');
            //    }
            //}


            if (!context.Books.Any())
            {
                using (var reader = new StreamReader("../../../books.txt"))
                {
                    var line = reader.ReadLine();
                    line = reader.ReadLine();
                    Random random = new Random();
                    var authors = context.Authors;
                    while (line != null)
                    {
                        var data = line.Split(new[] { ' ' }, 6);
                        var authorId = random.Next(3, authors.Count() + 1);
                        var edition = (EditionType)int.Parse(data[0]);
                        var releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                        var copies = int.Parse(data[2]);
                        var price = Decimal.Parse(data[3]);
                        var ageRestriction = (AgeRestriction) int.Parse(data[4]);
                        var title = data[5];
                        var categoriesCount = random.Next(0, context.Categories.Count());
                        var listOfCategories = new List<Category>();


                        for (int i = 0; i < categoriesCount; i++)
                        {
                            var index = random.Next(0, categoriesCount);
                            listOfCategories.Add(context.Categories.ToArray()[i]);
                        }

                        context.Books.Add(new Book()
                        {
                            Title = title,
                            EditionType = edition,
                            Price = price,
                            Copies = copies,
                            ReleaseDate = releaseDate,
                            AuthorId = authorId,
                            AgeRestriction = ageRestriction,
                            Categories = listOfCategories
                        });

                        line = reader.ReadLine();
                    }
                }
            }

            if (!context.Categories.Any())
            {
                using (var reader = new StreamReader("../../../categories.txt"))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        context.Categories.Add(new Category()
                        {
                            Name = line
                        });
                        line = reader.ReadLine();
                    }
                }
            }

            
        }


        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data. E.g.
        //
        //    context.People.AddOrUpdate(
        //      p => p.FullName,
        //      new Person { FullName = "Andrew Peters" },
        //      new Person { FullName = "Brice Lambson" },
        //      new Person { FullName = "Rowan Miller" }
        //    );
        //
    }
}

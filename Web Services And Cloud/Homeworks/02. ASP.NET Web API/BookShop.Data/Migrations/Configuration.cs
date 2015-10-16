namespace BookShop.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BookShop.Data.BooksShopContext";

        }

        protected override void Seed(BooksShopContext context)
        {
            FillAuthors(context);
            FillCategories(context);
        }

        public void FillCategories(BooksShopContext context)
        {
            var categories = context.Categories.Any();

            if (!categories)
            {
                var reader = new StreamReader("../../../categories.txt");
                var line = reader.ReadLine();

                while (line != null)
                {
                    context.Categories.Add(new Category()
                    {
                        Name = line
                    });
                    line = reader.ReadLine();
                }
                context.SaveChanges();
            }
        }

        public void FillBooks(BooksShopContext context)
        {
            var books = context.Books.Any();

            if (!books)
            {
                var reader = new StreamReader("../../../books.txt");
                var line = reader.ReadLine();
                line = reader.ReadLine();
                Random random = new Random();

                while (line != null)
                {
                    var categoriesCount = context.Categories.Count();
                    var randomNumberOfCategoryCount = random.Next(1, categoriesCount + 1);
                    var listOfCategories = new List<Category>();

                    for (int i = 0; i < randomNumberOfCategoryCount; i++)
                    {
                        var index = random.Next(0, randomNumberOfCategoryCount);
                        listOfCategories.Add(context.Categories.ToArray()[index]);
                    }

                    var currLine = line.Split(new[] {' '}, 6);

                    //TO DO...
                }
            }
        }

        public void FillAuthors(BooksShopContext context)
        {
            var authors = context.Authors.Any();

            if (!authors)
            {
                var reader = new StreamReader("../../../authors.txt");
                var line = reader.ReadLine();
                line = reader.ReadLine();

                while (line != null)
                {
                    var currLine = line.Split(' ');
                    var firstName = currLine[0];
                    var lastName = currLine[1];

                    context.Authors.Add(new Author()
                    {
                        FirstName = firstName,
                        LastName = lastName
                    });
                    line = reader.ReadLine();
                }

                context.SaveChanges();
            }
        }
    }
}

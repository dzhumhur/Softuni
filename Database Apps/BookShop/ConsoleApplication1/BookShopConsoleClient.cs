using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksShop.Data;
using BookShoop.Models;

namespace ConsoleApplication1
{
    class BookShopConsoleClient
    {
        static void Main(string[] args)
        {
           var context = new BookShopContext();
           
            // 6.1  Get all Books After the year 2000. Select only their titles
           var books = context.Books
               .Where(b => b.ReleaseDate >= new DateTime(2000, 12, 31))
               .Select(b => b.Title)
               .ToList();
            //books.ForEach(b => Console.WriteLine(b));
          

            // 6.2  Get all authors with at least one book with release date before 1990. 
            //      Select their first name and last name.
            var authors = context.Authors
                .Where(a => a.Books.Any(b => b.ReleaseDate >= new DateTime(1999, 1, 1)))
                .Select(b => new
                {
                    b.FirstName,
                    b.LastName
                })
                .ToList();
            //authors.ForEach(a => Console.WriteLine("{0} {1}", a.FirstName, a.LastName));


            // 6.3	Get all authors, ordered by the number of their books (descending).
            //      Select their first name, last name and book count.
            var authorsTheirsBooks = context.Authors
                .OrderByDescending(a => a.Books.Count)
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                    a.Books.Count
                })
                .ToList();
            //authorsTheirsBooks.ForEach(a => Console.WriteLine("{0} {1} - Books: {2}",
            //    a.FirstName,
            //    a.LastName,
            //    a.Count));


            // 6.4	Get all books from author George Powell, ordered by their release date (descending),
            //      then by book title (ascending). Select the book's title, release date and copies.
            var georgeBooks = context.Books
                .Where(b => b.Authors.FirstName == "George" && b.Authors.LastName == "Powell")
                .OrderByDescending(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .Select(b => new
                {
                    b.Title,
                    b.ReleaseDate,
                    b.Copies
                })
                .ToList();
            //georgeBooks.ForEach(a => Console.WriteLine("{0} - {1:d} - {2}",
            //    a.Title,
            //    a.ReleaseDate,
            //    a.Copies));


            // 6.5	Get the most recent books by categories. The categories should be ordered by total book count.
            //      Only take the top 3 most recent books from each category - ordered by date (descending), 
            //      then by title (ascending). Select the category name, total book count and 
            //      for each book - its title and release date.
            var booksByCategories = context.Categories
                .OrderByDescending(c => c.Books.Count)
                .Select(b => new
                {
                   b.Name,
                   b.Books.Count,
                   bookNames = context.Books
                   .OrderByDescending(bo => bo.ReleaseDate)
                   .ThenBy(bo => bo.Title)
                   .Select(bo => new
                   {
                       bo.Title,
                       bo.ReleaseDate
                   })
                   .Take(3)
                   .ToList()
                })
                .ToList();

            booksByCategories.ForEach(b =>
            {
                Console.WriteLine("--{0} {1}", b.Name, b.Count);
                b.bookNames.ForEach(book => Console.WriteLine("{0} ({1:y})",
                    book.Title, book.ReleaseDate));
                Console.WriteLine();
            });
        }
    }
}

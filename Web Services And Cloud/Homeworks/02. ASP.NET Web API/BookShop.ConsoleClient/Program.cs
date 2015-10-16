using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ConsoleClient
{
    using Data;

    class Program
    {
        static void Main(string[] args)
        {
            var context = new BooksShopContext();
            var books = context.Books.Count();
            Console.WriteLine(books);
        }
    }
}

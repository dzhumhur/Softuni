namespace _01.BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            var goldenEditionBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);

            Console.WriteLine(book);
            Console.WriteLine();
            Console.WriteLine(goldenEditionBook);
        }
    }
}

namespace _03.PC_Catalog
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
            var toshiba = new Computer("Toshiba Celeron", 2500, "Intel Core i7 2.80 GHz", 700);
            var dell = new Computer("Dell Inspiron N5110R", 1500, "Intel Core i7 2.20 GHz", 500);
            var asus = new Computer("Asus Aspire 23", 1300, "Intel Core i3 1.9 GHz", 200, "8 Mb Cache, QuadCore",
                                    "nVidia GForce GT 750", 250, "ASUS Z97 PRO GAMER", 250,
                                    "Kingston 125", 100, 
                                    "Nadfd 12", 150);
            var lenovo = new Computer("Lenovo Alien 564", 1400, "Intel Core i5 2.0 GHz", 300, "AMD Radeon 5656", 100);

            var pcs = new List<Computer> { toshiba, dell, asus, lenovo };
            pcs = pcs.OrderBy(p => p.Price).ToList();

            pcs.ForEach(Console.WriteLine);

        }
    }
}

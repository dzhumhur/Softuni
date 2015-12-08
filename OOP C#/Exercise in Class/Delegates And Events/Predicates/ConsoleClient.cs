using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 2, 3, 6, 4, 11, 3 };

            Console.WriteLine(Extensions.FirstOrDefault(collection, x => x > 7));
            Console.WriteLine(Extensions.FirstOrDefault(collection, x => x < 0));

            Console.WriteLine(string.Join(", ", Extensions.TakeWhile(collection, x => x < 10)));

            //Extensions.ForEach(collection, Console.WriteLine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Mappings
{
    class ListContinents
    {
        static void Main()
        {
            var context = new GeographyEntities();

            // Problem 1. Entity Framework Mappings (Database First)
            // 1.9  To list all continent names
            var continents = context.Continents
                .Select(c => c.ContinentName)
                .ToList();
            continents.ForEach(c => Console.WriteLine("{0}", c));


        }
    }
}

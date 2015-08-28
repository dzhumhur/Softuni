using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _01.EntityFrameworkMapping
{
    using System.Linq;

    class EntityFrameworkMapping
    {

        static void Main()
        {
            var context = new DiabloEntities();
            var characters = context.Characters
                .Select(ch => ch.Name)
                .ToList();
            characters.ForEach(c => Console.WriteLine(c));
        }
    }
}

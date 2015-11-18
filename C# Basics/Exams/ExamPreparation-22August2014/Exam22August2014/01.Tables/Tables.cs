using System;
using System.Collections.Generic;
using System.Linq;
class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToMade = long.Parse(Console.ReadLine());

        long allLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tablesPossible = Math.Min(tableTops, allLegs / 4);

        if (tablesPossible == tablesToMade)
        {
            Console.WriteLine("Just enough tables made: {0}",tablesToMade);
        }
        else if (tablesPossible > tablesToMade)
        {
            Console.WriteLine("more: {0}",tablesPossible-tablesToMade);
            Console.WriteLine("tops left: {0}, legs left: {1}",
                tableTops-tablesToMade, allLegs - tablesToMade*4);
        }
        else
        {
            Console.WriteLine("less: {0}",tablesPossible - tablesToMade);
            Console.WriteLine("tops needed: {0}, legs needed: {1}",
                Math.Max(0, tablesToMade - tableTops),
                Math.Max(0,tablesToMade*4 - allLegs));
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
class TablesMySolution
{
    static void Main(string[] args)
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToMade = long.Parse(Console.ReadLine());
        long legsNeeded = 0;

        long allLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);

        if (tableTops < tablesToMade)
        {
            if (tablesToMade * 4 < allLegs)
            {
                Console.WriteLine("less: {0}", tableTops - tablesToMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",
                    tablesToMade - tableTops, legsNeeded);
            }
            else
            {
                legsNeeded = tablesToMade * 4 - allLegs;
                Console.WriteLine("less: {0}", tableTops - tablesToMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",
                    tablesToMade - tableTops, legsNeeded);
            }
        }
        else if (tableTops > tablesToMade && allLegs == tablesToMade * 4)
        {
            Console.WriteLine("Just enough tables made: {0}", tablesToMade);
        }
        else if (tableTops > tablesToMade)
        {
            Console.WriteLine("more: {0}", tableTops - tablesToMade);
            Console.WriteLine("tops left: {0}, legs left: {1}",
                tableTops - tablesToMade, allLegs - tablesToMade * 4);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesToMade);
        }
    }
}

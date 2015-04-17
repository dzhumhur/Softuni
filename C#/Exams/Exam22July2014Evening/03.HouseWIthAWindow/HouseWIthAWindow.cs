using System;
using System.Collections.Generic;
using System.Linq;
class HouseWIthAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int houseWidth = 2 * n - 1;

        Console.WriteLine(new string('.', n - 1) + '*' + new string('.', n - 1));
        int outerPoints = n - 2;
        int innerPoints = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerPoints), new string('.', innerPoints));
            outerPoints--;
            innerPoints += 2;
        }
        Console.WriteLine(new string('*',n*2  - 1));


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.',houseWidth - 2));
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
class Problem3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 2;
        int innerDots = n + 2;
        int secondInnerDots = n;
        int secondOuterDots = 1;

        Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine(new string('.', outerDots) + '*' + new string('.', innerDots) + '*' + new string('.', outerDots));
            outerDots -= 2;
            innerDots += 4;
        }
        outerDots = n - 2;

        for (int i = 0; i < n/2; i++)
        {
            if (i == 0 )
            {
                Console.WriteLine('*' + new string('.', outerDots) + '*' + new string('.', secondInnerDots) + '*' + new string('.', outerDots) + '*');
                outerDots -= 2;
            }
            else
            {
                Console.WriteLine('*' + new string('.',outerDots) + '*' + new string('.',secondOuterDots) + '*' + new string('.',secondInnerDots) + 
                                  '*' + new string('.',secondOuterDots) + '*' + new string('.',outerDots) + '*');
                outerDots -= 2;
                secondOuterDots += 2;
            }
        }
        outerDots = n - 1;
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine(new string('.',outerDots) + '*' + new string('.',secondInnerDots) + '*' + new string('.',outerDots));
            outerDots--;
            secondInnerDots+=2;
        }
        Console.WriteLine(new string('*',n*3));


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
class Car
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int roofBodyHeight = input / 2;
        int wheelsHeight = (input/2)  - 1;

        for (int i = 0; i <= roofBodyHeight; i++)
        {
            string outerDots = new string('.', input - i);
            string innerDots = new string('.', 3 * input - (2 * (input - i)) - 2);
            if (i == 0)
            {
                innerDots = new string('*', 3 * input - (2 * (input - i)) - 2);
            }
            if (i == roofBodyHeight)
            {
                outerDots = new string('.', input - i);

            }
            Console.WriteLine("{0}*{1}*{0}", outerDots, innerDots);
            if (i == roofBodyHeight)
            {
                outerDots = new string('.', input - i);

            }
        }

        for (int i = 0; i < roofBodyHeight - 1; i++)
        {
            string dots = new string('.', 3 * input - 2);
            if (i == roofBodyHeight - 2)
            {
                dots = new string('*', 3 * input - 2);
            }
            Console.WriteLine("*{0}*",dots);
        }
    }
}


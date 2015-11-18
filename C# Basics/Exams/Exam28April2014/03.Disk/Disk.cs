using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        int centreY = n / 2;
        int centreX = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                double distanceToCentre = Math.Sqrt(i * i + k * k);

                if (distanceToCentre < r)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}


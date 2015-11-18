using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        int gcd = 1;
        if (a>b)
        {
            c = b;
        }
        else if (b>a)
        {
            c = a;
        }
        else if (a==b)
        {
            c = a;
        }
        if (c >= 1)
        {
            for (int i = 1; i < c; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
        }
        else
        {
            for (int i = 1; i > c; i--)
            {
                if (i != 0)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        gcd = i;
                        gcd = Math.Abs(gcd);
                    }
                }
            }
        }
        Console.WriteLine(gcd);
    }
}
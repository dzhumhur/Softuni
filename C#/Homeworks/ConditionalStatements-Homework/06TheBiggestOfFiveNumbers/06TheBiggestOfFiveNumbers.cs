using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        //variant 1
        double min = double.MinValue;
        if (a>=min)
        {
            min = a;
        }
        if (b >= min)
        {
            min = b;
        }
        if (c >= min)
        {
            min = c;
        }
        if (d >= min)
        {
            min = d;
        }
        if (e >= min)
        {
            min = e;
        }
        Console.WriteLine(min);

        //variant 2
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}
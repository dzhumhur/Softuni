using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1 = 0;
        double x2 = 0;
        double diskriminanta = (b * b) - (4 * a *c);
        if (diskriminanta < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (diskriminanta == 0)
        {
            x1 = -(b) / (2 * a);
            Console.WriteLine("x1=x2={0}", x1);
        }
        else
        {
            x1 = (-(b) - Math.Sqrt(diskriminanta)) / (2 * a);
            x2 = (-(b) + Math.Sqrt(diskriminanta)) / (2 * a);
            Console.WriteLine("x1={0}; x2={1}", x1, x2);
        }
    }
}
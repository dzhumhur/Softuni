using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input h: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("Trapezoid area is: {0}", (a + b) * h / 2);

    }
}
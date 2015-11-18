using System;

class Triangle
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double a = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2)); // AB
        double b = Math.Sqrt(Math.Pow((cX - bX), 2) + Math.Pow((cY - bY), 2)); // CB
        double c = Math.Sqrt(Math.Pow((aX - cX), 2) + Math.Pow((aY - cY), 2)); // AC
        if (a + b > c && a + c > b && b + c > a)
        { 
            Console.WriteLine("Yes");
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", a);
        }


    }
}
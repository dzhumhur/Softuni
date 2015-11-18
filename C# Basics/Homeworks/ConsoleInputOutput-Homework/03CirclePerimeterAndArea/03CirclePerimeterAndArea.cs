using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of the circle is {0:0.00}", 2 * Math.PI * r);
        Console.WriteLine("The area of the circle is {0:0.00}", Math.PI * r * r);
    }
}
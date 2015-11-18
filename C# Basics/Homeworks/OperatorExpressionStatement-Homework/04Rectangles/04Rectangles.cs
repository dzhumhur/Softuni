using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Input the rectangle widht: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Input the rectangle height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter is: " + 2*(width + height));
        Console.WriteLine("The area is: " + (width*height));
    }
}
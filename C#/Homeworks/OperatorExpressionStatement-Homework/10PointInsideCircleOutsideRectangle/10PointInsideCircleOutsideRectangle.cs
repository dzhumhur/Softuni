using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = Math.Pow(x -1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5, 2);
        bool isInRectangle = y > 1;
        Console.WriteLine(isInCircle && isInRectangle ? "Yes" : "No");
    }
}
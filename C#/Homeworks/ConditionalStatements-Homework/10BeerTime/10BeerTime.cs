using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter time in \"hh:mm tt\" format: ");
        DateTime isBeer = DateTime.Parse(Console.ReadLine());
        DateTime startBeer = DateTime.Parse("01:00 PM");
        DateTime endBeer = DateTime.Parse("03:00 AM");

        if (isBeer >= startBeer || isBeer < endBeer)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}
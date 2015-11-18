using System;

class DiffBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        double diff = (secondDate - firstDate).TotalDays;
        Console.WriteLine(diff);
    }
}
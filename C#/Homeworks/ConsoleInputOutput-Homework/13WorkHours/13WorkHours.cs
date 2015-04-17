using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double productivity = (double)p / 100;
        double realWorkDays = d * 0.9 * 12;
        int totalWorkHours = 0;
        double efficintWorkHours = realWorkDays * productivity;
        totalWorkHours = h - (int)efficintWorkHours;
        if (totalWorkHours > 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(-(totalWorkHours));
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(-(totalWorkHours));
        }

    }
}
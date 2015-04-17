using System;
using System.Collections.Generic;
using System.Linq;
class Budget
{
    static void Main()
    {
        const int totalDays = 30;
        const int totalWeeks = 4;

        int money = int.Parse(Console.ReadLine());
        int weekDaysOut = int.Parse(Console.ReadLine());
        int hometownsWeekends = int.Parse(Console.ReadLine());

        int normalWeeks = ((totalWeeks - hometownsWeekends) * 2) * 20;
        int normalWeekDays = (totalDays - (totalWeeks * 2)) - weekDaysOut;
        normalWeekDays *= 10;
        int sumWeekDaysOut = (((int)(money * 0.03) * (weekDaysOut)) + (weekDaysOut * 10));
        
        int result = normalWeeks + normalWeekDays + sumWeekDaysOut + 150;

        if (money > result)
        {
            Console.WriteLine("Yes, leftover {0}.", money - result);
        }
        else if (money == result)
        {
            Console.WriteLine("Exact Budget.");
        }
        else
        {
            Console.WriteLine("No, not enough {0}.",Math.Abs(result - money));
        }
    }
}
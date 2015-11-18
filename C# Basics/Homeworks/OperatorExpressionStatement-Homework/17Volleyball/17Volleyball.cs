using System;

class Volleyball
{
    static void Main()
    {
        string isLeap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double totalPlays = 0;

        totalPlays += h;
        totalPlays += (48 - h) * 3.0/ 4.0;
        totalPlays += p * 2.0 / 3.0;
        if (isLeap == "leap")
        {
            totalPlays += totalPlays * 0.15;
            Console.WriteLine((int)totalPlays);
        }
        else
        {
            Console.WriteLine((int)totalPlays);
        }
    }
}
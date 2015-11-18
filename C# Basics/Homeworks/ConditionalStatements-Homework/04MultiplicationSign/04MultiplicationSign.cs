using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int countMinus = 0;
        if (a < 0)
        {
            countMinus++;
            if (b < 0)
            {
                countMinus++;
                if (c < 0)
                {
                    countMinus--;
                }
            }
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (countMinus % 2 == 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
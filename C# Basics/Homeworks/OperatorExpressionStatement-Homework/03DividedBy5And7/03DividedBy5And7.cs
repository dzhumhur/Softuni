using System;

class DividedBy5And7
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int isDivide = int.Parse(Console.ReadLine());

        if (isDivide % 5 == 0 && isDivide % 7 == 0)
        {
            Console.WriteLine("{0} is divided by 5 and 7. - {1}", isDivide, true);
        }
        else
        {
            Console.WriteLine("{0} is divided by 5 and 7. - {1}", isDivide, false);
        }
    }
}
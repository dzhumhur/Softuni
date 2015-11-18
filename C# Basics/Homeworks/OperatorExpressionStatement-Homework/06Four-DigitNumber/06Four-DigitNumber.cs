using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Input four digit number: ");
        int fourDigitNum = int.Parse(Console.ReadLine());
        int a = fourDigitNum / 1000;
        int b = (fourDigitNum / 100) % 10;
        int c = (fourDigitNum / 10) % 10;
        int d = (fourDigitNum / 1) % 10;

        Console.WriteLine("Sum of digits is: " + (a + b + c + d));
        Console.WriteLine("Revers: " + d + c + b + a);
        Console.WriteLine("Last digit in the first position: " + d + a + b + c);
        Console.WriteLine("Exchanges the second and the third digits: " + a + c + b + d);
    }
}
using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Intup a integer number: ");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        n /= 100;
        bool is3rdDigit7 = n % 10 == 7;
        Console.WriteLine("The 3rd digit is 7: " + is3rdDigit7);
    }
}
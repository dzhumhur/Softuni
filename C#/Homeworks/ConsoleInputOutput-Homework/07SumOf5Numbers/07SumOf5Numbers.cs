using System;

class SumOf5Numbers
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        double num1 = double.Parse(numbers[0]);
        double num2 = double.Parse(numbers[1]);
        double num3 = double.Parse(numbers[2]);
        double num4 = double.Parse(numbers[3]);
        double num5 = double.Parse(numbers[4]);
        Console.WriteLine(num1 + num2 + num3 + num4 + num5);
    }
}
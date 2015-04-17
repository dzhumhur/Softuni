using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("|{0}|{1}|", Convert.ToString(a, 16).PadRight(10, ' '), Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.WriteLine("{0,10:0.00}|{1,-10:0.000}|", b, c);

    }
}
namespace _02.Fraction_Calculator
{
    using System;
    using System.Numerics;

    class ConsoleClient
    {
        static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
            Console.WriteLine();

            Fraction fraction3 = new Fraction(22, 7);
            Fraction fraction4 = new Fraction(40, 4);
            Fraction result2 = fraction1 - fraction2;
            Console.WriteLine(result2.Numerator);
            Console.WriteLine(result2.Denominator);
            Console.WriteLine(result2);

        }
    }
}

using System;

class CalculateNfactXnth
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double nFact = 1;
        double xNth = 1;
        double sum = 1;
        for (double i = 1; i <= n; i++)
        {
            nFact *= i;
            xNth = Math.Pow(x, i);
            sum += nFact / xNth;
        }
        Console.WriteLine("{0:0.00000}", sum);
    }
}
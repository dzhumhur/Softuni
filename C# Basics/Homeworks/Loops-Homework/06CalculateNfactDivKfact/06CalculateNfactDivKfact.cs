using System;

class CalculateNfactDivKfact
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double nFact = 1;
        double kFact = 1;
        double max = Math.Max(n, k);
        double min = Math.Min(n, k);
        for (int i = 1; i <= max; i++)
        {
            if (i <= max)
            {
                nFact *= i;
            }
            if (i <= min)
            {
                kFact *= i;
            }
        }
        Console.WriteLine(nFact/kFact);
    }
}
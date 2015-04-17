using System;

class CalculateCombinations
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double k = int.Parse(Console.ReadLine());
        double combination = 0;
        double nFact = 1;
        double kFact = 1;
        double nMinKFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            if (i <= k)
            {
                kFact *= i;
            }
        }
        for (int i = 1; i <= n -k; i++)
        {
            nMinKFact *= i;
        }
        combination = nFact / (kFact * nMinKFact);
        Console.WriteLine(combination);
    }
}
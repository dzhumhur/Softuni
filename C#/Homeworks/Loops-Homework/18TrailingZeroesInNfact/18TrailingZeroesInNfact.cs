using System;
using System.Numerics;
// За който не му се чака да провери дали работи с последният пример(100000 -> 24999). При мен върти цикъла 2-3мин.
// Може и заради машината ми да се бави толкова, но работи :)
class TrailingZeroesInNfact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        BigInteger checkZero = 0;
        do
        {
            nFact = nFact / 10;
            checkZero++;
        } while (nFact % 10 == 0);

        Console.WriteLine(checkZero);
    }
}
using System;
using System.Numerics;
//C = (2N)! / ((N + 1)! * N!)
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger n2Fact = 1;
        BigInteger nPlus1Fact = 1;
        BigInteger catalan = 0;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= 2 * n; i++)
        {
            n2Fact *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nPlus1Fact *= i;
        }
        catalan = n2Fact / (nPlus1Fact * nFact);
        Console.WriteLine(catalan);
    }
}
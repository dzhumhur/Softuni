using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        isPrime(n); 
    }

    private static void isPrime(BigInteger n)
    {
        bool isPrime = true;
        if (n > 0)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine("\n{0} is prime: {1}\n", n, isPrime);
        }
        else
        {
            Console.WriteLine("\nFalse\n");
        }
    }
}
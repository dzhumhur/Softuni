using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Input positive integer (n <= 100): ");
        int n = int.Parse(Console.ReadLine());
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
using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }

    private static void Fib(int n)
    {
        int fib1 = 0;
        int fib2 = 1;
        int fib3 = 0;
        for (int i = 0; i < n; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
        }
        Console.WriteLine(fib3);
    }
}
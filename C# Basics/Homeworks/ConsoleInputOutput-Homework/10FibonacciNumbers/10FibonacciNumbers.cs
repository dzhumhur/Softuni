using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int a = 0;
        int b = 1;
        if (n >= 3)
        {
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < n - 2; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
        else if (n == 2)
        {
            Console.WriteLine(a + " " + b);
        }
        else if (n == 1)
        {
            Console.WriteLine(a);
        }
    }
}
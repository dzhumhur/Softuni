using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dash = 0;
        int asterisk = 1;
        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', Math.Abs((n/2) - dash)), new string('*',asterisk));
            dash++;
            asterisk += 2;
        }
        
        Console.WriteLine("{0}", new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('|', 1), new string('*', n - 2));
        }
    }
}
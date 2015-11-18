using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int midDots = 1;
        int outDots = (n - 2 - midDots) / 2;

        Console.WriteLine("{0}{1}{0}",new string('.', n/2), new string('*', 1));
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine
                ("{0}{1}{2}{1}{0}", new string('.', outDots), new string('*', 1), new string('.', midDots));
            midDots += 2;
            outDots -= 1;
        }

        Console.WriteLine("{0}", new string('*', n));
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine
                ("{0}{1}{2}{1}{0}", new string('.', n / 4), new string('*', 1), new string('.', n - ((n / 4) * 2) - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n/4), new string('*', n - ((n/4)*2)));

    }
}

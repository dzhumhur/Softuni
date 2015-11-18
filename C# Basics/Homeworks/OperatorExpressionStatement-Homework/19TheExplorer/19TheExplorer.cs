using System;

class TheExplorer
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', (n -1) / 2), new string('*', 1));
        byte rows = (byte)((n - 3) / 2);
        byte outDashCount = rows;
        byte middleDashCount = 1;

        for (byte i = 0; i < rows; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDashCount), new string('*', 1), new string('-', middleDashCount));
            outDashCount--;
            middleDashCount += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('-', n - 2));
        
        outDashCount = 1;
        middleDashCount = (byte)(n - 4);
        for (byte i = 0; i < rows; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDashCount), new string('*', 1), new string('-', middleDashCount));
            outDashCount++;
            middleDashCount -= 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
    }
}
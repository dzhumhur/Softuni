using System;
using System.Collections.Generic;
using System.Linq;
class LettersSymbolsNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int letterSum = 0;
        int symbolSum = 0;
        int digitSum = 0;

        for (int i = 0; i < count; i++)
        {
            string currentString = Console.ReadLine().ToLower();

            foreach (var ch in currentString)
            {
                if (ch != ' ' &&
                    ch != '\t' &&
                    ch != '\r' &&
                    ch != '\n')
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        int weight = (ch - 'a' + 1) * 10;
                        letterSum += weight;
                    }
                    else if (ch >= '0' && ch <= '9')
                    {
                        int weight = (ch - '0') * 20;
                        digitSum += weight;
                    }
                    else
                    {
                        symbolSum += 200;
                    }
                }
            }
        }
        Console.WriteLine(letterSum);
        Console.WriteLine(digitSum);
        Console.WriteLine(symbolSum);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
class DoubleDowns
{
    static void Main()
    {
        int amount = int.Parse(Console.ReadLine());
        int[] numbers = new int[amount];
        int rightDiagonalCounter = 0;
        int lefttDiagonalCounter = 0;

        int verticalDiagonalCounter = 0;

        for (int i = 0; i < amount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length-1; i++)
        {
            int topNumber = numbers[i];
            int bottomNumber = numbers[i + 1];
            for (int bit = 0; bit < 32; bit++)
            {
                int mask = 1 << bit;
                bool checkTopBit = (topNumber & mask) > 0;
                if (checkTopBit && (bottomNumber & (mask >> 1)) > 0)
                {
                    rightDiagonalCounter++;
                }
                if (checkTopBit && (bottomNumber & (mask<<1)) > 0)
                {
                    lefttDiagonalCounter++;
                }
                if (checkTopBit && (bottomNumber & mask) > 0)
                {
                    verticalDiagonalCounter++;
                }
            }
        }
        Console.WriteLine(rightDiagonalCounter);
        Console.WriteLine(lefttDiagonalCounter);
        
        Console.WriteLine(verticalDiagonalCounter);
    }
}


using System;

//Problem 16. Print Long Sequence Version 2 - Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, 


class PrintLongSequenceV2
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        int i = 2;
        Console.WriteLine(i);
        while (i <= 1001)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
            i++;
        }
    }
}


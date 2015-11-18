using System;

//Problem 16. Print Long Sequence Version 1 - Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, 

class PrintLongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i <= 1001; i++)
        {
            if (i == 1001)
            {
                Console.WriteLine(i + ".");
            }
            else
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + ";");
                }
                else
                {
                    Console.WriteLine(-i + ";");
                }
        }       
    }        

}
﻿using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
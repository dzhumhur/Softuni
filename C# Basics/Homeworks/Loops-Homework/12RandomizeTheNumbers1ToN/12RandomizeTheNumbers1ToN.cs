using System;
using System.Collections.Generic;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        Random randomGen = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNum = randomGen.Next(0, numbers.Count);
            Console.Write("{0} ", numbers[randomNum]);
            numbers.RemoveAt(randomNum);
        }
    }
}
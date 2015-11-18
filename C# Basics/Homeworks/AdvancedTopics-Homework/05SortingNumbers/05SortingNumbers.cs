using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
			{
			    int element = int.Parse(Console.ReadLine());
                numbers.Add(element);
			}
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
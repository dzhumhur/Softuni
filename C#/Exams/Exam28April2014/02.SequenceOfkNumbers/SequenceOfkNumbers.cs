using System;
using System.Collections.Generic;
class SequenceOfkNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
        int k = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        int count = 1;
        

        for (int i = 0; i < input.Length; i++)
        {
            array.Add(Convert.ToInt16(Convert.ToString(input[i])));
        }

        for (int i = 1; i < array.Count; i++)
        {
            int currentI = i;
            int firstElementValue = i - 1;

            if (array[firstElementValue] == array[i])
            {
                count++;
                if (count == k)
                {
                    for (int j = currentI; j >= 0; j--)
                    {
                        array.RemoveAt(currentI);
                    }
                    i--;
                }
                count = 1;
                
            }
            else
            {
                count--;
            }
        }

        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

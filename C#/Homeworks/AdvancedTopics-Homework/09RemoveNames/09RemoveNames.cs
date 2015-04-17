using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');

        List<string> first = new List<string>();
        for (int i = 0; i < firstLine.Length; i++)
        {
            first.Add(firstLine[i]);
        }

        for (int secondArray = 0; secondArray < secondLine.Length; secondArray++)
        {
            for (int listIndex = 0; listIndex < first.Count; listIndex++)
            {
                if (first[listIndex] == secondLine[secondArray]) 
                {
                    first[listIndex] = null;
                }
            }
        }
        for (int i = 0; i < first.Count; i++)
        {
            if (first[i] == null)
            {
                Console.Write(first[i]);
            }
            else
            {
                Console.Write(first[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
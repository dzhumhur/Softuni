using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<char> letters = new List<char>();
        foreach (var letter in input)
        {
            letters.AddRange(letter);
        }
        letters.Sort();
        int counter = 1;
        for (int i = 1; i < letters.Count; i++)
        {
            if (letters[i] == letters[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} --> {1}", letters[i - 1], counter);
                counter = 1;
            }

            if (i == letters.Count - 1)
            {
                Console.WriteLine("{0} --> {1}", letters[i], counter);
            }
        }
    }
}
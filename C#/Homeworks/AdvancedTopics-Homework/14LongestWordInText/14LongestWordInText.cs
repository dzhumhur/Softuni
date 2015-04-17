using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInText
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(
            new char[] {' ', '.', ',', '-', '!', '?', ':', ';', '(', ')', '\"', '\"'});
        List<string> words = text.ToList<string>();
        int maxLetters = 0;
        string longestWord = "";
        for (int word = 0; word < words.Count; word++)
        {
            if (words[word].Length >= maxLetters)
            {
                maxLetters = words[word].Length;
                longestWord = words[word];
            }
        }
        Console.WriteLine(longestWord);
    }
}
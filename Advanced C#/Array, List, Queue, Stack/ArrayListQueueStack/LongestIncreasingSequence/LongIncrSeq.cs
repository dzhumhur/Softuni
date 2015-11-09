using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongIncrSeq
    {
        static void Main(string[] args)
        {
            int[] input =
                Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            List<int> sequence = new List<int>();
            int maxLength = 0;
            string longest = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                int firstElement = input[i];
                int nextElement = input[i + 1];
                if (firstElement < nextElement)
                {
                    sequence.Add(firstElement);
                }
                else
                {
                    sequence.Add(firstElement);
                    if (sequence.Count > maxLength)
                    {
                        maxLength = sequence.Count;
                        longest = string.Join(" ", sequence);

                    }
                    Console.WriteLine(string.Join(" ", sequence));
                    sequence.Clear();
                }
            }
            sequence.Add(input[input.Length - 1]);
            Console.WriteLine(string.Join(" ", sequence));
            if (sequence.Count > maxLength)
            {
                longest = string.Join(" ", sequence);
            }
            Console.WriteLine("Longest: {0}", longest);
        }
    }
}

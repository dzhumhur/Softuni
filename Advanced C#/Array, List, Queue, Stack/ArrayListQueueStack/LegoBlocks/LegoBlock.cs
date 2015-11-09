using System;
using System.Collections.Generic;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlock
    {
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int[]> firstMatrix = new List<int[]>();
            List<int[]> secondMatrix = new List<int[]>();
            List<List<int>> result = new List<List<int>>();
            
            for (int i = 0; i < n * 2; i++)
            {
                if (i < n)
                {
                    string input = Console.ReadLine();
                    int[] currArray = ReturnArray(input);
                    firstMatrix.Add(currArray);
                }
                else
                {
                    string input = Console.ReadLine();
                    int[] currArray = ReturnArray(input);
                    secondMatrix.Add(currArray);
                }
            }

            int counter = 0;
            counter = Result(firstMatrix, secondMatrix, counter, result);

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i].Count != result[i + 1].Count)
                {
                    Console.WriteLine("The total number of cells is: {0}", counter);
                    return;
                }
            }

            result.ForEach(a =>
            {
                Console.Write("[" + string.Join(", ", a) + "]");
                Console.WriteLine();
            });
        }
        private static int Result(List<int[]> firstMatrix, List<int[]> secondMatrix, int counter, List<List<int>> result)
        {
            for (int i = 0; i < firstMatrix.Count; i++)
            {
                var first = firstMatrix[i].ToList();
                var second = secondMatrix[i].Reverse().ToList();
                counter += first.Count;
                counter += second.Count;
                List<int> currList = new List<int>();
                currList.AddRange(first);
                currList.AddRange(second);
                result.Add(currList);
            }
            return counter;
        }
        private static int[] ReturnArray(string input)
        {
            int[] currArray =
                        input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            return currArray;
        }
    }
}

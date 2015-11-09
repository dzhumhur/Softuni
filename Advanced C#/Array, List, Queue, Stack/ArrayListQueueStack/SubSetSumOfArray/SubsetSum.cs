using System;
using System.Collections.Generic;
using System.Linq;

namespace SubSetSumOfArray
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> input = new HashSet<int>(
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<int> result = new List<int>();
 
            GetCombination(input, result, n);
        }
        static void GetCombination(HashSet<int> list, List<int> result, int n)
        {
            bool find = false;
            double count = Math.Pow(2, list.Count);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        result.Add(list.ElementAt(j));
                    }
                }
                int sum = result.Sum();
                if (sum == n)
                {
                    find = true;
                    Console.WriteLine(string.Join(" + ", result) + " = " + sum);                    
                }
                result.Clear();
            }
            if (!find)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}

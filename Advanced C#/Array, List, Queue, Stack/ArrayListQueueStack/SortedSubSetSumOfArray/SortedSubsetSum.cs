namespace SortedSubSetSumOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortedSubsetSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> input = new HashSet<int>(
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var allLists = GetCombination(input, n);
            allLists = SortCombinations(allLists);
            foreach (var allList in allLists)
            {
                foreach (var i in allList)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static List<List<int>> GetCombination(HashSet<int> list, int n)
        {
            List<int> result = new List<int>();
            List<List<int>> allLists = new List<List<int>>();
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
                    allLists.Add(new List<int>(result));
                }
                result.Clear();
            }

            return allLists;
        }
        private static List<List<int>> SortCombinations(List<List<int>> list)
        {
            list.Sort((x, y) =>
            {
                x.Sort();
                y.Sort();
                if (x.Count == y.Count)
                {
                    return x[0] - y[0];
                }

                return x.Count - y.Count;

            });
            return list;
        }
    }
}

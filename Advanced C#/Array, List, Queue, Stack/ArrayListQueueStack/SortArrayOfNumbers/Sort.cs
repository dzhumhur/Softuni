using System;
using System.Linq;

namespace SortArrayOfNumbers
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] input =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(input);
            input.ToList().ForEach(Console.WriteLine);
        }
    }
}

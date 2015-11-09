using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JaggedArray
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            List<int> firsRowLength = new List<int>();
            List<int> secondRowLength = new List<int>();
            List<int> thirdRowLength = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 3 == 0)
                {
                    firsRowLength.Add(number);
                }
                else if (number % 3 == 1)
                {
                    secondRowLength.Add(number);
                }
                else
                {
                    thirdRowLength.Add(number);
                }
            }
            int[] zeros = firsRowLength.ToArray();
            int[] ones = secondRowLength.ToArray();
            int[] twos = thirdRowLength.ToArray();
            int[][] result = { zeros, ones, twos };

            for (int row = 0; row < result.Length; row++)
            {
                for (int col = 0; col < result[row].Length; col++)
                {
                    Console.Write("{0} ", result[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

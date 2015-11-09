using System;

namespace MaximalPlatform
{
    class MaximalPlatform
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {2, 4, 6, 9},
                {12, 5, 18, 1},
                {1, 20, 3, 9},
                {2, 34, 3, 7},
            };

            int[,] result =
            {
                {0, 0},
                {0, 0}
            };

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] +
                                  matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                        result[0, 0] = matrix[row, col];
                        result[0, 1] = matrix[row, col + 1];
                        result[1, 0] = matrix[row + 1, col];
                        result[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine("Best sum : {0}", bestSum);
            Console.WriteLine("[{0}, {1}]\n[{2}, {3}]", 
                                result[0, 0],
                                result[0, 1],
                                result[1, 0],
                                result[1, 1]);
        }
    }
}

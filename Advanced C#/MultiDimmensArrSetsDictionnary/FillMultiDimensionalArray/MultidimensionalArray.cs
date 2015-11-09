using System;

namespace FillMultiDimensionalArray
{
    class MultidimensionalArray
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {2, 3, 5, 6,},
                {7, 8, 9, 1},
                {11, 12 ,13, 14}
            };
            int matrix0 = matrix.GetLength(0);
            int matrix1 = matrix.GetLength(1);
            for (int row = 0; row < matrix0; row++)
            {
                for (int col = 0; col < matrix1; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace SnakeMatrix
{
    using System;

    class SnakeMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int counter = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        counter++;
                        matrix[row, col] = counter;
                    }
                }
                else
                {
                    for (int revCol = cols - 1; revCol >= 0; revCol--)
                    {
                        counter++;
                        matrix[row, revCol] = counter;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} " , matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

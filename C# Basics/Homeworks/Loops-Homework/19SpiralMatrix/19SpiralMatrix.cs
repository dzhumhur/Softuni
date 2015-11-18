using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n, n];
        int row = 0;
        int col = 0;
        int num = 1;

        for (int i = 1; i <= n * n; i++)
        {

            while (true)
            {
                spiralMatrix[row, col] = num;
                if (col + 1 < n && spiralMatrix[row, col + 1] == 0)
                {
                    ++col;
                    ++num;
                }
                else break;
            }
            while (true)
            {
                spiralMatrix[row, col] = num;
                if (row + 1 < n && spiralMatrix[row + 1, col] == 0)
                {
                    ++row;
                    ++num;
                }
                else break;
            }
            while (true)
            {
                spiralMatrix[row, col] = num;
                if (col - 1 >= 0 && spiralMatrix[row, col - 1] == 0)
                {
                    --col;
                    ++num;
                }
                else break;
            }
            while (true)
            {
                spiralMatrix[row, col] = num;
                if (row - 1 >= 0 && spiralMatrix[row - 1, col] == 0)
                {
                    --row;
                    ++num;
                }
                else break;
            }
        }



        for (int printRow = 0; printRow < n; printRow++)
        {
            for (int printCol = 0; printCol < n; printCol++)
            {
                Console.Write("{0,4} ", spiralMatrix[printRow, printCol]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
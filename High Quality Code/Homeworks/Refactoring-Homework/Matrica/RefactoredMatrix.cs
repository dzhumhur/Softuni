namespace Task3
{
    using System;

    class RefactoredMatrix
    {
        private static void Change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }

            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }

        private static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private static bool CheckCell(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[number, number];
            int step = number;
            int value = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;
            while (true)
            {
                // malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[row, col] = value;
                if (!CheckCell(matrix, row, col))
                {
                    break;
                }

                // prekusvame ako sme se zadunili
                bool outOfBoundaries = row + directionX >= number || row + directionX < 0 || col + directionY >= number
                                       || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0;

                while (outOfBoundaries)
                {
                    Change(ref directionX, ref directionY);
                }


                row += directionX;
                col += directionY;
                value++;
            }

            FindCell(matrix, out row, out col);
            if (row != 0 && col != 0)
            {
                // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                directionX = 1;
                directionY = 1;

                while (true)
                {
                    // malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[row, col] = value;
                    if (!CheckCell(matrix, row, col))
                    {
                        break;
                    }
                    // prekusvame ako sme se zadunili
                    if (row + directionX >= number || row + directionX < 0 || col + directionY >= number
                        || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                    {
                        while (row + directionX >= number || row + directionX < 0 || col + directionY >= number
                               || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                        {
                            Change(ref directionX, ref directionY);
                        }
                    }

                    row += directionX;
                    col += directionY;
                    value++;
                }
            }

            for (int arrRow = 0; arrRow < number; arrRow++)
            {
                for (int arrCol = 0; arrCol < number; arrCol++)
                {
                    Console.Write("{0,3}", matrix[arrRow, arrCol]);
                }

                Console.WriteLine();
            }
            //}
            //}
        }
    }
}
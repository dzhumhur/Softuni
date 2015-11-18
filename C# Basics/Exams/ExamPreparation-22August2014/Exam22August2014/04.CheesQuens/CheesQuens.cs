using System;
using System.Collections.Generic;
using System.Linq;
class CheesQuens
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int counter = 0;
        string[,] board = new string[size, size];

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                board[row, col] = "" + (char)('a' + row) + (col + 1);
            }
        }

        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (row + distance +1 < board.GetLength(0))
                {
                    Console.WriteLine("{0} - {1}", board[row, col], board[row + distance + 1, col]);
                    Console.WriteLine("{1} - {0}", board[row, col], board[row + distance + 1, col]);
                    counter += 2;
                }
                if (col + distance + 1 < board.GetLength(1))
                {
                    Console.WriteLine("{0} - {1}", board[row, col], board[row, col + distance + 1]);
                    Console.WriteLine("{1} - {0}", board[row, col], board[row, col + distance + 1]);
                    counter += 2;
                }
                if (row + distance + 1 < board.GetLength(0) && col + distance + 1 < board.GetLength(1)) // right diagonal
                {
                    Console.WriteLine("{0} - {1}", board[row, col], board[row + distance + 1, col + distance + 1]);
                    Console.WriteLine("{1} - {0}", board[row, col], board[row + distance + 1, col + distance + 1]);
                    counter += 2;
                }
                if (row + distance + 1 < board.GetLength(0) && col - distance - 1 >= 0) // left diagonal
                {
                    Console.WriteLine("{0} - {1}", board[row, col], board[row + distance + 1, col - distance - 1]);
                    Console.WriteLine("{1} - {0}", board[row, col], board[row + distance + 1, col - distance - 1]);
                    counter += 2;
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No valid positions");
        }








        //for (int rows = 1; rows <= size; rows++)
        //{
        //    for (int cols = 1; cols < size; cols++)
        //    {
        //        if (cols + distance + 1 <= size)
        //        {
        //            Console.WriteLine("{0} - {1}","" + (char)(96+rows)+cols, "" + (char)(96 + rows) + (cols + distance + 1));
        //            Console.WriteLine("{1} - {0}", "" + (char)(96 + rows) + cols, "" + (char)(96 + rows) + (cols + distance + 1));
        //        }
        //        if (rows + distance + 1 <=size)
        //        {
        //            Console.WriteLine("{0} - {1}", "" + (char)(96 + rows) + cols, "" + (char)(96 + rows) + (distance + 1 + cols));
        //        }
        //        if (rows+distance+1 <= size && cols+ distance+1<=size)
        //        {
        //            Console.WriteLine(,"" + (char)(96+rows) + cols, "" + (char(96+rows+distance+  1)(cols+distance+1)));
        //        }
        //    }
        //}
    }
}


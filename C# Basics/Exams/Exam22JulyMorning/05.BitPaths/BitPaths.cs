using System;
using System.Collections.Generic;
using System.Linq;
class BitPaths
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] board = new int[8];

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] currentPath = input.Split(',');
            int[] path = new int[8];
            //int[] path = input.Split(',').Select(int.Parse).ToArray();
            //int[] path = Array.ConvertAll(input.Split(','),element => int.Parse(element));

            for (int j = 0; j < 8; j++)
            {
                path[j] = int.Parse(currentPath[j]);
            }

            int position = 3 - path[0];

            for (int k = 0; k < 8; k++)
            {
                board[k] = board[k] ^ (1 << position);
                if (k == 7)
                {
                    break;
                }
                position -= path[k + 1];
            }
        }
        int sum = board.Sum();
        Console.WriteLine(Convert.ToString(sum,2));
        Console.WriteLine("{0:X}",sum);
    }
}


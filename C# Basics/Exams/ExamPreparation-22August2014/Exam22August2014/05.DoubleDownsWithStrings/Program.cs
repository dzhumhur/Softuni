using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DoubleDownsWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string[] numbers = new string[amount];
            int rightDiagonalCounter = 0;
            int lefttDiagonalCounter = 0;

            int verticalDiagonalCounter = 0;

            for (int i = 0; i < amount; i++)
            {
                numbers[i] = Convert.ToString(int.Parse(Console.ReadLine(), 2
                    );
            }


            Console.WriteLine(rightDiagonalCounter);
            Console.WriteLine(lefttDiagonalCounter);

            Console.WriteLine(verticalDiagonalCounter);
        }
    }
}

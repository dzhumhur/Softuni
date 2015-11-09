using System;
using System.Linq;

namespace BubbleSort
{
    class ImplementBubbleSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] inputAsArray = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int first = 0; first < inputAsArray.Length - 1; first++)
            {
                for (int second = first + 1; second < inputAsArray.Length; second++)
                {
                    int firstNumber = inputAsArray[first];
                    int secondNumber = inputAsArray[second];
                    if (firstNumber > secondNumber)
                    {
                        var checker = secondNumber;
                        inputAsArray[second] = firstNumber;
                        inputAsArray[first] = checker;
                    }
                }
            }

            foreach (var item in inputAsArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

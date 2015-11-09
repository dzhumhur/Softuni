using System;
using System.Linq;

namespace StuckNumbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputAsArray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int len = inputAsArray.Length;
            bool isFind = false;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        for (int l = 0; l < len; l++)
                        {
                            if ((i != j) && (i != l) &&
                                 (i != k) && (j != k) &&
                                  (j != l) && (k != l)){

                                string firstPair = "" + inputAsArray[i] + inputAsArray[j];
                                string secondPair = "" + inputAsArray[k] + inputAsArray[l];
                                if (firstPair.Equals(secondPair))
                                {
                                    isFind = true;
                                    Console.WriteLine("{0}|{1}=={2}|{3}",
                                        inputAsArray[i], inputAsArray[j], inputAsArray[k], inputAsArray[l]);
                                }
                                
                            }
                        }
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }

        }
    }
}

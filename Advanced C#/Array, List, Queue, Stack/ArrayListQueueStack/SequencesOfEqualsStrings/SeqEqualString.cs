using System;
using System.Collections.Generic;
using System.Linq;

namespace SequencesOfEqualsStrings
{
    class SeqEqualString
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int inputLength = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i].Equals(input[i + 1]))
                {
                   result.Add(input[i]);
                }
                else
                {
                    result.Add(input[i]);
                    Console.WriteLine(string.Join(" ", result));
                    result.Clear();
                }
            }
            result.Add(input[input.Length - 1]);
            Console.WriteLine(string.Join(" ", result));
        }
         //for (int i = 0; i < input.Length - 1; i++)
         //   {
         //       var counter = 1;
         //       for (int j = i + 1; j < input.Length; j++)
         //       {
         //           if (!input[i].Equals(input[j]))
         //           {
         //              break;
         //           }
         //           counter++;
         //       }
         //       int index = i;
         //       if (counter != 1)
         //       {
         //           i += counter - 1;
         //           inputLength = i;
         //       }
         //       while (counter > 0)
         //       {
         //           Console.Write(input[index] + " ");
         //           counter--;
         //       }
         //       Console.WriteLine();
         //   }
         //   if (inputLength < input.Length - 1)
         //   {
         //       Console.WriteLine(input[input.Length - 1]);
         //   }
    }
}

namespace SelectionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SelSort
    {
        static void Main(string[] args)
        {
            int[] input =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[k])
                    {
                        k = j;
                    }
                }
                int temp = input[i];
                input[i] = input[k];
                input[k] = temp;
                Console.WriteLine(string.Join(", ", input));
            }
            Console.WriteLine(string.Join(", ", input));

            //for (int z = 0; z < input.Length - 1; z++)
            //{
            //    int minElement = input[z];
            //    int forChange = input[z];
            //    int index = 0;
            //    bool find = false;
            //    for (int i = z + 1; i < input.Length; i++)
            //    {
            //        int currElement = input[i];
            //        if (currElement < minElement)
            //        {
            //            minElement = currElement;
            //            index = i;
            //            find = true;
            //        }
            //    }
            //    if (find)
            //    {
            //        input[z] = minElement;
            //        input[index] = forChange;
            //    }
            //}
            //Console.WriteLine(string.Join(", ", input));


        }
    }
}

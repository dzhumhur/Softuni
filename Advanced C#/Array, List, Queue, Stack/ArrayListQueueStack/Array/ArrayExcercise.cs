using System.Linq;

namespace Array
{
    using System;

    internal class ArrayExcercise
    {
        private static void Main(string[] args)
        {
            // check.Distinct()
            int[] check = { 1, 4, 5, 6, 10, 60, 1 };
            var secondCheck = check.Distinct();
            foreach (var item in secondCheck)
            {
                //Console.WriteLine(item);
            }
            Console.WriteLine(check.Skip(1).FirstOrDefault());

            //return;

            // Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] input =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            string[] arr = { "0", "126", "595" };
            int counter = 0;
            foreach (var i in arr)
            {
                Console.WriteLine("element[{0}] = {1}", counter, i);
                counter++;
            }

            // Array.ConvertAll
            int[] newArray = Array.ConvertAll(arr, int.Parse);

            newArray.ToList().ForEach(Console.WriteLine);

            // Array.Clear
            Array.Clear(arr, 1, arr.Length - 1);

            // Array.IndexOf
            Console.WriteLine(Array.IndexOf(newArray, 126));


            Console.WriteLine(string.Join("\n", arr));
        }
    }
}


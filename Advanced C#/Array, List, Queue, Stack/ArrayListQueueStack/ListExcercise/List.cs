using System.Collections.Generic;

namespace ListExcercise
{
    using System;
    class List
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] arr = {3, 5, 6};
            int[] arrr = {200, 500, 600};
            int n = 5;

            while (n > 0)
            {
                list.Add(n);
                n--;
            }
            list.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();

            // list.Count
            Console.WriteLine(list.Count);

            // list.Capacity
            Console.WriteLine(list.Capacity);

            // AddRange
            list.AddRange(arr);
            list.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();

            // list.IndexOf
            Console.WriteLine(list.IndexOf(5));

            // list.Insert
            list.Insert(3, 100);
            list.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();

            // list.InsertRange
            list.InsertRange(4, arrr);
            list.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();

            list.RemoveAt(1);
            list.Remove(6);
            list.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();


        }
    }
}

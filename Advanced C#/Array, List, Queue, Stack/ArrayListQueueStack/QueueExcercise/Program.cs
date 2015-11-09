using System.Collections.Generic;

namespace QueueExcercise
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(1);
            queue.Enqueue(100);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}

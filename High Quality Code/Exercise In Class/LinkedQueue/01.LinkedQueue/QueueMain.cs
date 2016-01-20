namespace _01.LinkedQueue
{
    using System;

    class QueueMain
    {
        public static void Main()
        {
            var q = new LinkedQueue<int>();

            q.Enqueue(1);
            q.Enqueue(4);
            q.Enqueue(44);
            q.Enqueue(56);

            Console.WriteLine(string.Join(" ", q));

            Console.WriteLine(q.Peek());
        }
    }
}

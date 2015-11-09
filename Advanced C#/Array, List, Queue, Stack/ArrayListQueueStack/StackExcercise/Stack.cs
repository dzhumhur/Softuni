using System.Collections.Generic;

namespace StackExcercise
{
    using System;
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // stack.Push()
            stack.Push(5);
            stack.Push(10);

            // stack.Peek()
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);

            // stack.Pop()
            stack.Pop();
            Console.WriteLine(stack.Count);

            // stack.Contains
            Console.WriteLine(stack.Contains(6));
        }
    }
}

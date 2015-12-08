namespace BookStore.UI
{
    using Interfaces;
    using System;

    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}

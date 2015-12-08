﻿namespace BookStore.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Books;
    using Interfaces;

    public class BookStoreEngine
    {
        private readonly IRenderer renderer;
        private readonly IInputHandler inputHandler;
        private readonly List<IBook> books;
        private decimal revenue;

        public BookStoreEngine(IInputHandler inputHandler, IRenderer renderer)
        {
            this.IsRunning = true;
            this.books = new List<IBook>();
            this.revenue = 0;
            this.inputHandler = inputHandler;
            this.renderer = renderer;
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            while (this.IsRunning)
            {
                string command = this.inputHandler.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                string[] commandArgs = command.Split();

                string commandResult = this.ExecuteCommand(commandArgs);

                this.renderer.WriteLine(commandResult);
            }

            this.renderer.WriteLine(string.Format("Total revenue: {0:F2}", this.revenue));
        }

        private string ExecuteCommand(string[] commandArgs)
        {
            switch (commandArgs[0])
            {
                case "add":
                    return this.ExecuteAddBookCommand(commandArgs);
                case "sell":
                    return this.ExecuteSellBookCommand(commandArgs);
                case "remove":
                    return this.ExecuteRemoveBookCommand(commandArgs);
                case "stop":
                    this.IsRunning = false;
                    return "Goodbye!";
                default:
                    return "Unknown command";
            }
        }

        private string ExecuteRemoveBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            IBook bookToRemove = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToRemove == null)
            {
                return "Book does not exist";
            }

            this.books.Remove(bookToRemove);

            return "Book removed";
        }

        private string ExecuteSellBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            IBook bookToSell = this.books.FirstOrDefault(book => book.Title.Equals(title));

            if (bookToSell == null)
            {
                return "Book does not exist";
            }

            this.revenue += bookToSell.Price;
            this.books.Remove(bookToSell);

            return "Book sold";
        }

        private string ExecuteAddBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            string author = commandArgs[2];
            decimal price = decimal.Parse(commandArgs[3]);

            this.books.Add(new Book(title, author, price));

            return "Book added";
        }
    }
}

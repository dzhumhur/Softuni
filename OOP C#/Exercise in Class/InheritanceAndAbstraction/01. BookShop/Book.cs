namespace _01.BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null, empty or whitespaces");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null, empty or whitespaces");
                }

                this.author= value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3:F2}",
                               this.GetType().Name,
                               this.Title,
                               this.Author,
                               this.Price);
        }
    }
}

namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;

    public class Author
    {
        private string firstName;
        private ICollection<Book> books;

        public Author()
        {
            this.books = new HashSet<Book>();
        }
        public int Id { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can not be empty/null");
                }

                this.firstName = value;
            }
        }

        public string LastName { get; set; }

        public virtual ICollection<Book> Books {
            get { return this.books; }
            set { this.books = value; }
        } 
    }
}

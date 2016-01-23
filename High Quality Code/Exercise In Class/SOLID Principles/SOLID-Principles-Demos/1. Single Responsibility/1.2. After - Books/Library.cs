namespace SingleResponsibilityBooksAfter
{
    using System.Collections.Generic;
    using System.Linq;

    public class Library
    {
        private IList<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public Book FindBook(string title)
        {
            var book = this.books.FirstOrDefault(b => b.Title.Equals(title));
            return book;
        }
    }
}

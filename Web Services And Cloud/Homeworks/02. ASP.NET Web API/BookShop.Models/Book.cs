namespace BookShop.Models
{
    using System.Collections.Generic;

    public class Book
    {
        private ICollection<Category> categories;


        public Book()
        {
            this.categories = new HashSet<Category>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Copies { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public Edition Edition { get; set; }

        public virtual ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }
    }
}

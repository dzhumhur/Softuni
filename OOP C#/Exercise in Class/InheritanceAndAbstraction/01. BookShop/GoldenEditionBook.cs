namespace _01.BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) 
            : base(title, author, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }

            set
            {
                base.Price = value * 1.3m;
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

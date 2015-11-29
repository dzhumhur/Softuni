namespace CompanyHierarchy
{
    using System;

    public class Sales
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Product name cannot be empty, null or whitespaces");
                }

                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",
                                 this.ProductName,
                                 this.Date,
                                 this.Price);
        }
    }
}

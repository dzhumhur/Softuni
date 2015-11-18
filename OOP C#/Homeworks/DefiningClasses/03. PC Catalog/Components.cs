namespace _03.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price) : this(name, price, null)
        {

        }

        public Components(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }
    }
}

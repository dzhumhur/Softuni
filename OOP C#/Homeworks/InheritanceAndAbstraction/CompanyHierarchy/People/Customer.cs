using CompanyHierarchy.Interfaces;
using System;

namespace CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount)
                       : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Purchase amount cannot be negative");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n",
                                base.ToString(),
                                this.NetPurchaseAmount);
        }
    }
}

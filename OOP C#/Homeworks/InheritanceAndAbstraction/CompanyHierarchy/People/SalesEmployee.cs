namespace CompanyHierarchy
{
    using Enums;
    using Interfaces;
    using System.Collections.Generic;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sales> sales = new List<Sales>();

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department)
                               : base(id, firstName, lastName, salary, department)
        {
            
        }

        public IEnumerable<Sales> Sales
        {
            get { return this.sales; }
        }

        public void AddSale(Sales sale)
        {
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

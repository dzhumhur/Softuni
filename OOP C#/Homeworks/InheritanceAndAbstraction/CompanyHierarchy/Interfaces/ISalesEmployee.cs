namespace CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        IEnumerable<Sales> Sales { get; }

        void AddSale(Sales sale);
    }
}

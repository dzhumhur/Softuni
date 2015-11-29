namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IManager
    {
        IEnumerable<Employee> Employees { get; }

        void AddEmployee(Employee employee); 
    }
}

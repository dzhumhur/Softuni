namespace CompanyHierarchy
{
    using Enums;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Manager : Employee, IManager
    {
        private List<Employee> employees = new List<Employee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Department department)
                      : base(id, firstName, lastName, salary, department)
        {

        }

        public IEnumerable<Employee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

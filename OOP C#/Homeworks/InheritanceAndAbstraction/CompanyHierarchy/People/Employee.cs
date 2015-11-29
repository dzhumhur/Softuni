namespace CompanyHierarchy
{
    using Enums;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
                       : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary cannot be negative");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}\nSalary: {1}\nDepartment: {2}\n",
                                 base.ToString(),
                                 this.Salary,
                                 this.Department);
        }
    }
}

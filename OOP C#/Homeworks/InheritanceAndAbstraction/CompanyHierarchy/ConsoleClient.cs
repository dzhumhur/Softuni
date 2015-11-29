using CompanyHierarchy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Manager(1, "Marin", "Stefanov", 500, Department.Accounting),
                new Manager(2, "Stefan", "Iliev", 650, Department.Marketing),
                new SalesEmployee(5, "Nikola", "Nikolov", 750, Department.Production),
                new SalesEmployee(7, "Preslav", "Nakov", 300, Department.Sales),
                new Developer(4, "Pesho", "Peshov", 200, Department.Accounting),
                new Developer(10, "Gosho", "Goshov", 100, Department.Accounting),
            };

            employees.ForEach(Console.WriteLine);
        }
    }
}

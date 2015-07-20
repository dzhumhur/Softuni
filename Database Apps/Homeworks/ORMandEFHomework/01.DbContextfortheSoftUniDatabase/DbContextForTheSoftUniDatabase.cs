using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.DbContextfortheSoftUniDatabase
{
    class DbContextForTheSoftUniDatabase
    {
        static void Main()
        {
            // Adding employee !!!
            //var person = new Employee()
            //{
            //    FirstName = "Manol",
            //    LastName = "Kirilov",
            //    MiddleName = "Yankov",
            //    JobTitle = "Chapadjiq",
            //    DepartmentID = 3,
            //    ManagerID = null,
            //    HireDate = new DateTime(2008, 5, 1, 8, 30, 52),
            //    Salary = 16.5M,
            //    AddressID = null
            //};
            //DaoClasss.Add(person);

            // Finding employee by key !!!
            var emp = DaoClasss.FindByKey(45);
            Console.WriteLine(emp.FirstName);

            //// Problem 3. Database Search Queries
            //// 3.1
            var ctx = new SoftUniEntities();
            Console.WriteLine("--3.1--");
            var employees = ctx.Projects
                .Where(e => e.StartDate.Year >= 2001 && e.StartDate.Year <= 2003)
                .Select(e => new
                {
                    e.Name,
                    e.StartDate,
                    e.EndDate
                    // There is no manager name
                });
            foreach (var employee in employees)
            {
                Console.WriteLine("PN: {0} - Start: {1} - End: {2}",
                    employee.Name,
                    employee.StartDate,
                    employee.EndDate);
            }
            Console.WriteLine();

            //// 3.2
            Console.WriteLine("--3.2--");
            var addresses = ctx.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .Take(10)
                .ToList();

            addresses.ForEach(a => Console.WriteLine("{0}, {1} - {2} employees",
                a.AddressText, a.Town.Name, a.Employees.Count));
            Console.WriteLine();

            //// 3.3 
            Console.WriteLine("--3.3--");
            var empById = ctx.Employees.Find(147);
            var employeeProjects = empById.Projects
                .OrderBy(empProj => empProj.Name)
                .Select(empProj => empProj.Name).ToList();


            Console.WriteLine("Employee data: {0} {1} - {2}",
                empById.FirstName,
                empById.LastName,
                empById.JobTitle
                );
            Console.WriteLine("Employee projects:");
            employeeProjects.ForEach(proj => Console.WriteLine(proj));
            Console.WriteLine();

            // 3.4
            Console.WriteLine("--3.4--");
            var departments = ctx.Departments
                .Where(dep => dep.Employees.Count > 5)
                .OrderBy(dep => dep.Employees.Count)
                .Select(dep => new
                {
                    DepartmentName = dep.Name,
                    ManagerName =  dep.Employees
                                    .Where(e => e.EmployeeID == dep.ManagerID)
                                    .Select(e => e.FirstName + " " + e.LastName).FirstOrDefault(),
                    Employees = dep.Employees
                                .Select(e => new
                                {
                                    e.FirstName,
                                    e.LastName,
                                    e.HireDate,
                                    e.JobTitle
                                }).ToList()
                }).ToList();
            var count = departments.Count;
            Console.WriteLine(count);
            departments.ForEach(d =>
            {
                Console.WriteLine("----{0} - Manager: {1}, Employees: {2} ",
                    d.DepartmentName,
                    d.ManagerName,
                    d.Employees.Count);
                //d.Employees.ForEach(e =>
                //{
                //    Console.WriteLine("{0} {1} - {2}, {3}",
                //        e.FirstName,
                //        e.LastName,
                //        e.HireDate,
                //        e.JobTitle);
                //});
                Console.WriteLine();
            });

        }
    }
}
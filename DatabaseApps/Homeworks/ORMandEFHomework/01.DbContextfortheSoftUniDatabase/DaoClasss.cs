using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DbContextfortheSoftUniDatabase
{
    public class DaoClasss
    {
        private static SoftUniEntities ctx = new SoftUniEntities();
        public static void Add(Employee employee)
        {
            ctx.Employees.Add(employee);
            ctx.SaveChanges();
        }

        public static Employee FindByKey(object key)
        {
            var employee = ctx.Employees.Find(key);

            if (employee == null)
            {   
                throw new ObjectNotFoundException("Not found employee with this Id");
            }
            return employee;
        }

        public static void Modify(Employee employee, string name)
        {

        }

        public static void Delete(Employee employee)
        {

        }
    }
}

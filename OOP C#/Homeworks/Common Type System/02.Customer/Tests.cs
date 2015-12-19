using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class Tests
    {
        public static void Main(string[] args)
        {
            var customer = new Customer("penka", "dragan", "petkan", "1",
                "lyubo", "sdfsdf", "cankov@abv.bg",  new List<Payment>() { new Payment("tergdfb", 20)},
                CustomerType.OneTime);

            var copy = (Customer) customer.Clone();

            Console.WriteLine(customer == copy);
            Console.WriteLine(customer);
            copy.FirstName = "Changes!";
            Console.WriteLine(customer);
            Console.WriteLine(copy);
        }
    }
}

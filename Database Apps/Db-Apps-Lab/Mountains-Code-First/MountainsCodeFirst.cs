using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First
{
    class MountainsCodeFirst
    {
        static void Main(string[] args)
        {
            var context = new MountainsContext();
            var countries = context.Countries.Count();
           
            var newCountry = new Country()
            {
                Name = "ZZ Country",
                Code = "ZZ"
            };
            context.Countries.Add(newCountry);
            context.SaveChanges();
            //Console.WriteLine(countries);
        }
    }
}

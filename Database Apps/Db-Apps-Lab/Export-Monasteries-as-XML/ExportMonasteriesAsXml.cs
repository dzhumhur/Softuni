using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export_Monasteries_as_XML
{
    using System.Diagnostics.Contracts;
    using System.Xml.Linq;
    using EF_Mappings;

    class ExportMonasteriesAsXml
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var countriesWithTheirMonasteries = context.Countries
                .Where(c => c.Monasteries.Count > 0)
                .OrderBy(c => c.CountryName)
                .Select(c => new
                {
                    c.CountryName,
                    Monasteries = c.Monasteries
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                    .ToList()
                })
                .ToList();

            var xmlMonansteries = new XElement("monasteries");

            foreach (var country in countriesWithTheirMonasteries)  
            {
                var xmlCountry = new XElement("country");
                xmlCountry.Add(new XAttribute("name", country.CountryName));
                xmlMonansteries.Add(xmlCountry);
                foreach (var monastery in country.Monasteries)
                {
                    xmlCountry.Add(new XElement("monastery", monastery));
                }
            }
            var xmlDoc = new XDocument(xmlMonansteries);
            xmlDoc.Save("monasteries.xml");
            Console.WriteLine(xmlDoc);

           
            //countriesWithTheirMonasteries.ForEach(c =>
            //{
            //    Console.WriteLine("--{0}--", c.CountryName);
            //    var count = 1;
            //    c.Monasteries.ForEach(m =>
            //    {
            //        Console.WriteLine("{0}. {1}",count, m);
            //        count++;
            //    });
            //    Console.WriteLine();
            //});
        }
    }
}

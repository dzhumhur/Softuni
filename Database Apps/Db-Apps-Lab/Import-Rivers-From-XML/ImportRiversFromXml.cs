using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import_Rivers_From_XML
{
    using System.Data.Entity.Migrations;
    using System.Diagnostics.Contracts;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using EF_Mappings;

    class ImportRiversFromXml
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var rivers = context.Rivers
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    r.Outflow,
                    r.DrainageArea,
                    r.AverageDischarge,
                    Countries = r.Countries
                    .Select(c => c.CountryName)
                    .ToList()
                })
                .ToList();

            var xmlDoc = XDocument.Load(@"..\..\riversToAdd.xml");

            var riversNodes = (xmlDoc.XPathSelectElements("rivers/river")).ToList();
            riversNodes.ForEach(rn =>
            {
                var countryNodes = rn.XPathSelectElements("countries/country");
                var countryNames = countryNodes.Select(c => c.Value).ToList();

                string riverName = rn.Element("name").Value;
                int riverLength = int.Parse(rn.Element("length").Value);
                string riverOutFlow = rn.Element("outflow").Value;
                int? riverDrainage = null;
                int? riverAvgDischarge = null;

                if (rn.Element("drainage-area") != null)
                {
                    riverDrainage = int.Parse(rn.Element("drainage-area").Value);
                }
                
                if (rn.Element("average-discharge") != null)
                {
                    riverAvgDischarge = int.Parse(rn.Element("average-discharge").Value);
                }

                var dbRiver = context.Rivers.FirstOrDefault(r => r.RiverName.Equals(riverName));
                countryNames.ForEach(cn =>
                {
                    if (!dbRiver.Countries.Contains(context.Countries.First(c => c.CountryName.Equals(cn))))
                    {
                        dbRiver.Countries.Add(context.Countries.First(c => c.CountryName.Equals(cn)));
                    }
                });

                //countryNames.ForEach(cn =>
                //{
                //    var country = context.Countries
                //        .FirstOrDefault(c => c.CountryName == cn);
                //    river.Countries.Add(country);
                //});
                context.Rivers.AddOrUpdate(dbRiver);
                context.SaveChanges();


                //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",
                //    riverName,
                //    riverLength,
                //    riverOutFlow,
                //    riverDrainage,
                //    riverAvgDischarge);

                //Console.WriteLine("{0} -> {1}", riverName, string.Join(", ", countries));

            });

            //rivers.ForEach(r =>
            //{
            //    Console.WriteLine("{0}, {1}, {2}, \"{3}\", \"{4}\"",
            //        r.RiverName,
            //        r.Length,
            //        r.Outflow,
            //        r.DrainageArea,
            //        r.AverageDischarge);
            //    r.Countries.ForEach(c =>
            //    {
            //        Console.WriteLine("{0}",c);
            //    });
            //    Console.WriteLine();
            //});

            //var xmlRivers = new XElement("rivers");
            
            //    rivers.ForEach(r =>
            //    {
            //        var xmlRiver = new XElement("river");
            //        xmlRivers.Add(xmlRiver);
            //        xmlRiver.Add(new XElement("name", r.RiverName));
            //        xmlRiver.Add(new XElement("length", r.Length));
            //        xmlRiver.Add(new XElement("outflow", r.Outflow));
            //        var drainageArea = r.DrainageArea;
            //        var averageDischarge = r.AverageDischarge;
            //        var countries = r.Countries;

            //        if (drainageArea != null)
            //        {
            //            xmlRiver.Add(new XElement("drainage-area", drainageArea));
            //        }
            //        if (averageDischarge != null)
            //        {
            //            xmlRiver.Add(new XElement("average-discharge", averageDischarge));
            //        }
            //        if (countries.Count > 0)
            //        {
            //            var xmlCountries = new XElement("countries");
            //            countries.ForEach(c =>
            //            {
            //                var xmlCountry = new XElement("contry", c); 
            //                xmlCountries.Add(xmlCountry);
            //            });
            //            xmlRiver.Add(xmlCountries);
            //        }
            //    });
            
            //var xmlDoc = new XDocument(xmlRivers);
            //xmlDoc.Save("rivers.xml");
            //Console.WriteLine(xmlDoc);
        }
    }
}

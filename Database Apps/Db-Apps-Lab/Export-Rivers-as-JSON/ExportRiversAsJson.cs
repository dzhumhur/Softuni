namespace Export_Rivers_as_JSON
{
    using EF_Mappings;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
   
    class ExportRiversAsJson
    {
        static void Main()
        {
            var context = new GeographyEntities();
            var rivers = context.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    RiversCountries = r.Countries
                    .OrderBy(c => c.CountryName)
                    .Select(c => c.CountryName)                
                    .ToList()
                })
                .ToList();
            var jsSerializer = new JavaScriptSerializer();
            var riversJson = jsSerializer.Serialize(rivers);
            StreamWriter file = new StreamWriter
                (@"E:\DISK D\Softuni-Projects\Modul Back-End\DB Apps July 2015\Exams\Db-Apps-Lab\Export-Rivers-as-JSON\bin\Debug\rivers.json");
            file.WriteLine(riversJson);
            file.Close();

            //rivers.ForEach(r =>
            //{
            //    Console.Write("River name: {0}, Length: {1}  ",
            //        r.RiverName,
            //        r.Length);
            //    Console.WriteLine();
            //    Console.WriteLine("Countries => ");
            //    r.RiversCountries.ForEach(c =>
            //    {
            //        if (r.RiversCountries.Count == 1)
            //        {
            //            Console.Write("{0}", c);
            //        }
            //        else
            //        {
            //            Console.Write("{0}, ", c);
            //        }
            //    });
            //    Console.WriteLine();
            //    Console.WriteLine();
            //});
        }
    }
}

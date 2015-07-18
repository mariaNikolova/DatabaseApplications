using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export_Rivers_as_JSON
{
    using System.Web.Script.Serialization;
    using EF_Mappings;
    //using System.Web.ex

    class ExportRiversAsJson
    {
        static void Main(string[] args)
        {
            var context = new GeographyEntities();
            /*
            var rivers = context.Rivers.Select(r =>
                new
                {
                    r.RiverName,
                    r.Length,
                    Countries = r.Countries.Select(c => c.CountryName)
                });
            foreach (var river in rivers)
            {
                foreach (var country in river.Countries)
                {
                    Console.WriteLine("{0} - {1} - {2}",river.RiverName, river.Length,country);
                }
                
            }
             */
            var riversQuery = context.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r => new
                {
                    r.RiverName,
                    r.Length,
                    Countries = r.Countries
                    .OrderBy(c => c.CountryName)
                    .Select(c => c.CountryName)
                });

            foreach (var river in riversQuery)
            {
                foreach (var country in river.Countries)
                {
                    //Console.WriteLine("{0} - {1} - {2}", river.RiverName, river.Length, country);
                }

            }
            var jsSerializer = new JavaScriptSerializer();
            var riversJson = jsSerializer.Serialize(riversQuery.ToList());
            Console.WriteLine(riversJson);

            System.IO.File.WriteAllText(@"D:\softuni\DatabaseAps\Lab\Solution\Db-Apps-Lab\Export-Rivers-as-JSON\bin\Debug\rivers.json", riversJson);
        }
    }
}

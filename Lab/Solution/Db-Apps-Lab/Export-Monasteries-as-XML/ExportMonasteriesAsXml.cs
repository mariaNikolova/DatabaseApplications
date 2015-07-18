using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export_Monasteries_as_XML
{
    using System.Xml.Linq;
    using EF_Mappings;

    class ExportMonasteriesAsXml
    {
        static void Main(string[] args)
        {
            var context = new GeographyEntities();
            /*
            foreach (var monastery in context.Monasteries) 
            {
                Console.WriteLine(monastery.Name);
            }
             */
            var countriesQuery = context.Countries 
                .Where(c => c.Monasteries.Any() != false)
                .OrderBy(c => c.CountryName)
                .Select(c => new
                {
                    c.CountryName,
                    Monasteries = c.Monasteries
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                });
            foreach (var country in countriesQuery)
            {
                Console.WriteLine(country.CountryName + " " + string.Join(", ", country.Monasteries));
            }

            var xmlMonasteries = new XElement("monasteries");
            foreach (var country in countriesQuery) 
            {
                var xmlCountry = new XElement("country");
                xmlCountry.Add(new XAttribute("name", country.CountryName));
                xmlMonasteries.Add(xmlCountry);
            
                foreach(var monastery in country.Monasteries)
                {
                    xmlCountry.Add(new XElement("monastery", monastery));
                }
            }
            //Console.WriteLine(xmlMonasteries);

            var xmlDoc = new XDocument(xmlMonasteries);
            xmlDoc.Save("monasteries.xml");
            
                
        }

    }
}

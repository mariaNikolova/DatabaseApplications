using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Entity;


namespace _2.ParseXMLToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"SoftUniRSSFeed.xml";
            XDocument doc = XDocument.Load(path);
            var result = JsonConvert.SerializeXNode(doc);
           
            Console.WriteLine(result);

        }

        
    }
}

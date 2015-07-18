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

namespace _3.LINQ_to_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "https://softuni.bg/Feed/News";
            string fileName = "SoftUniRSSFeed.xml";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(address, fileName);

             var path = @"SoftUniRSSFeed.xml";
            XDocument doc = XDocument.Load(path);
            var result = JsonConvert.SerializeXNode(doc);
            PrintQuestionTitle(result);
        }

        public static List<JToken> PrintQuestionTitle(string json)
        {
            var jsonObj = JObject.Parse(json);
            var titles = jsonObj["rss"]["channel"]["item"].ToList();
            foreach (var title in titles.Select(n => n["title"]))
            {
                Console.WriteLine(title);
            }
            return titles;
        }
    }
}

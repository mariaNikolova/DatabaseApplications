using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _1.Download
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "https://softuni.bg/Feed/News";
            string fileName = "SoftUniRSSFeed.xml";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(address, fileName);
        }
    }
}

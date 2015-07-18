using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceEntityFramework
{
    using AdsDbModel;
    using System.Data.Entity;
    class Program
    {
        static void Main(string[] args)
        {
            PrintAdsWithNPlusOneQueryProblem();
        }
        static void PrintAdsWithNPlusOneQueryProblem()
        {

            Console.WriteLine("List employees (with N+1 query problem):");
            var ads = new List<string>();
            var startTime = DateTime.Now;
            var context = new AdsEntities();
            foreach (var ad in context.Ads)
            {
                ads.Add(String.Format("Add: Title = {0}; Status = {1}; Town = {2}; User = {3}", 
                  ad.Title, ad.AdStatus.Status, ad.Category.Name, ad.Town.Name, ad.AspNetUser.Name));
            }
            Console.WriteLine("Time elapsed: {0}", DateTime.Now - startTime);
            Console.WriteLine(String.Join("\n", ads.Take(5)));
            Console.WriteLine("...");
            Console.WriteLine();
        }

    }
}

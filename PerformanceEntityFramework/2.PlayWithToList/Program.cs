using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdsDbModel;
using System.Data.Entity;

namespace _2.PlayWithToList
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAds();
        }


        private static void ShowAds()
        {
            var db = new AdsEntities();

            var ad = db.Ads.ToList();

            var starTime = DateTime.Now;

            var ads = db.Ads
                .ToList()
                .Where(a => a.AdStatus.Status == "Published")
                .Select(a => new
                {
                    a.Title,
                    a.Category,
                    a.Town,
                    a.Date
                })
                .ToList()
                .OrderBy(a => a.Date);

            var endTime = DateTime.Now;

            Console.WriteLine(endTime - starTime);
            Console.WriteLine(ads.Count());
           
           
        }
       
    }
}

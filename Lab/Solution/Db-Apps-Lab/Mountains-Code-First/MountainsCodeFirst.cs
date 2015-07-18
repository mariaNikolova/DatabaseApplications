using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mountains_Code_First.Migrations;

namespace Mountains_Code_First
{
    class MountainsCodeFirst
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MountainsContext, Configuration>());
            var context = new MountainsContext();

            Country c = new Country() { Code = "AB", Name = "Balgaria" };
            Mountain m = new Mountain() { Name = "Stara Planina" };
            m.Peaks.Add(new Peak() { Name = "Musala", Mountain = m });
            m.Peaks.Add(new Peak() { Name = "Vihren", Mountain = m });
            c.Mountains.Add(m);

            context.Countries.Add(c);
            context.SaveChanges();
        }
    }
}

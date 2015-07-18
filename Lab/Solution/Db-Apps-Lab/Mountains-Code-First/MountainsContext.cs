using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First
{
    class MountainsContext : DbContext
    {
        public MountainsContext()
            : base("MountainsContext")
        { 
        }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Mountain> Mountains { get; set; }

        public virtual DbSet<Peak> Peaks { get; set; }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    public class Resources
    {
        private int id;
        private string name;
        private TypeOfResource resource;
        private string link;

        public int Id { get; set; }
        public string Name { get; set; }
        public TypeOfResource Resource { get; set; }
        public string Link { get; set; }

        //public int CoursesId { get; set; }
       // public virtual Resources Resources{ get; set; } 

    }
}

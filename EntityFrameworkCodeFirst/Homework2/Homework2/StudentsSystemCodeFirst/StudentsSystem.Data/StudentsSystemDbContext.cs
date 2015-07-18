using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Data
{
    using System.Data.Entity;

    using StudentsSystem.Models;

    public class StudentsSystemDbContext : DbContext, IStudentSystemDbContext
    {

        public StudentsSystemDbContext()
            : base("StudentsSystem")
        {

        }
        public IDbSet<Students> Students { get; set; }

        public IDbSet<Courses> Courses { get; set; }

        public IDbSet<Resources> Resources { get; set; }

        public IDbSet<Homework> Homeworks{ get; set; }
    }
}

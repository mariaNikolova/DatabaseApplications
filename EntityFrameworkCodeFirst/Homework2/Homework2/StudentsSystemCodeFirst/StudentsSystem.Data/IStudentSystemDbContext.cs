using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Data
{
    using StudentsSystem.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    interface IStudentSystemDbContext
    {
        IDbSet<Students> Students { get; set; }
        IDbSet<Courses> Courses { get; set; }
        IDbSet<Homework> Homeworks { get; set; }
        IDbSet<Resources> Resources { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsSystem.Models;

namespace StudentsSystem.Data.Repositories
{
    public interface IStudentRepository : IRepository<Students>
    {
        IQueryable<Students> ListAllStudentsAndHomework();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsSystem.Models;

namespace StudentsSystem.Data.Repositories
{
    class StudentRepository : GenericRepository<Students>, IStudentRepository
    {
        public StudentRepository (StudentsSystemDbContext context) 
            : base(context)
        {

        }
        public IQueryable<Students> ListAllStudentsAndHomework()
        {
            return this.All().Where(s => s.Name.Any());
        }
    }
}

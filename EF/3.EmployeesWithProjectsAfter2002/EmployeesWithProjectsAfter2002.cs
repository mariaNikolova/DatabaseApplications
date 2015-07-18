using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EmployeesWithProjectsAfter2002
{  
    using EF;

    class EmployeesWithProjectsAfter2002
    {
        public static void SelectEmployeeWithProjectIn2002()
        {
            var softUniContext = new SoftUniEntities();
            IQueryable<Employee> employees =
                from e in softUniContext.Employees
                where e.HireDate.Year == 2002
                select e;

            foreach (var employee in employees)
            {
                Console.WriteLine("F: {0} , L: {1} ", employee.FirstName, employee.LastName);
            }
        }
    }
}

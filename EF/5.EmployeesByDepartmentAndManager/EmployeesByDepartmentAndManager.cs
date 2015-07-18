using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EmployeesByDepartmentAndManager
{
    using EF;

    class EmployeesByDepartmentAndManager
    {
        public static void EmployeesByDepartmentAndManagerFunc(string DepartmentName, string managerFirstName, string managerLastName)
        {
            using (var softUniEntities = new SoftUniEntities())
            {
               var employees =
                    from e in softUniEntities.Employees
                    where e.FirstName == managerFirstName && 
                          e.LastName == managerLastName && 
                          e.Department.Name == DepartmentName
                    select e;

                foreach (var em in employees)
                {
                    Console.WriteLine("{0} {1} {2}", em.FirstName, em.LastName, em.MiddleName);
                }
            }
        }
    }
}

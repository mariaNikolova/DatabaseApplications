using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NativeSQLQuery
{
    using EF;

    class NativeSQLQuery
    {
        public static IEnumerable<EmployeeIdAndName> SelectEmployeesIn2002NativeQuery()
        {
            SoftUniEntities northwindEntities = new SoftUniEntities();
            string nativeSqlQuery =
                "SELECT e.EmployeeID, e.FirstName FROM dbo.Employees e WHERE YEAR(e.HireDate) = 2002";
            var employees =
            northwindEntities.Database.SqlQuery<EmployeeIdAndName>(nativeSqlQuery);
            return employees;

        }
        public class EmployeeIdAndName
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
        }
    }
}

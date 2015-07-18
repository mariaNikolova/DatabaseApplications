using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NativeSQLQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = NativeSQLQuery.SelectEmployeesIn2002NativeQuery();
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}. {1}", employee.EmployeeID, employee.FirstName);
            }
        }
    }
}

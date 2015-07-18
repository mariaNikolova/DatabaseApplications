using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DAOClass
{
    using EF;

    class Program
    {
        static void Main(string[] args)
        {
           int employeeId = DAOClass.CreateNewEmployee("Kirilka", "Kirilova", "Developer", 2, DateTime.Now, 1000);
           Console.WriteLine("Created new employee.");

           DAOClass.ModifyEmployeeName(employeeId, "new Name Kirilka");
           Console.WriteLine("Modified the employee {0}.", employeeId);
           
           DAOClass.DeleteEmployee(employeeId);
            Console.WriteLine("Deleted the employee {0}.", employeeId);
           
        }
        
    }
}

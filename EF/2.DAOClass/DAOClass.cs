using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;

namespace _2.DAOClass
{
    class DAOClass
    {
        public static int CreateNewEmployee(string FirstName, string LastName, string JobTitle,
                                            int DepartmentId, DateTime HireDate, decimal Salary)
        {
            var softUniEntities = new SoftUniEntities();
            var newEmployee = new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                JobTitle = JobTitle,
                DepartmentID = DepartmentId,
                HireDate = HireDate,
                Salary = Salary
            };

            softUniEntities.Employees.Add(newEmployee);
            softUniEntities.SaveChanges();

            return newEmployee.EmployeeID;
        }
        public static void ModifyEmployeeName(int employeeId, string newFirstName)
        {
            var softUniEntities = new SoftUniEntities();
            Employee employee = GetEmployeeById(softUniEntities, employeeId);
            employee.FirstName = newFirstName;
            softUniEntities.SaveChanges();
        }

        public static Employee GetEmployeeById(SoftUniEntities entity, int employeeId)
        {
            Employee employee = entity.Employees
                .FirstOrDefault(p => p.EmployeeID == employeeId);

            return employee;
        }
        public static void DeleteEmployee(int employeeId)
        {
            var softUniEntities = new SoftUniEntities();
            Employee employee = GetEmployeeById(softUniEntities, employeeId);
            softUniEntities.Employees.Remove(employee);
            softUniEntities.SaveChanges();
        }

    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class EmployeeRepo
    {
        private static List<Employee> _allEmployees = new List<Employee>()
        {
            new Employee("Stipe", "Stipic", DateTime.Now, 1, "Test"),
            new Employee("Stipe", "Stipic", DateTime.Now, 2, "Test"),
            new Employee("Stipe", "Stipic", DateTime.Now, 3, "Test"),
            new Employee("Stipe", "Stipic", DateTime.Now, 4, "Test"),
            new Employee("Stipe", "Stipic", DateTime.Now, 5, "Test"),
        };

        public static List<Employee> GetEmployees()
        {
            return _allEmployees;
        }

        public static Employee GetEmployeeByOib(int oib)
        {
            foreach (var employee in _allEmployees)
            {
                if (employee.Oib == oib)
                    return employee;
            }
            return null;
        }

        public static bool TryAdd(string name, string lastName, DateTime dateOfBirth, int oib, string position)
        {
            foreach (var employee in _allEmployees)
            {
                if (employee.Oib == oib)
                    return false;
            }
            var newEmployee = new Employee(name, lastName, dateOfBirth, oib, position);
            _allEmployees.Add(newEmployee);
            return true;
        }

        public static void Remove(Employee toRemove)
        {
            _allEmployees.Remove(toRemove);
        }
    }
}

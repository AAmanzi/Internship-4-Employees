using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Enums;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class EmployeeRepo
    {
        private static List<Employee> _allEmployees = new List<Employee>()
        {
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*20, 0, 0, 0)), "1", Position.Developer),
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*29, 0, 0, 0)), "2", Position.Designer),
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*24, 0, 0, 0)), "3", Position.ProjectManager),
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*26, 0, 0, 0)), "4", Position.Slicer),
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*32, 0, 0, 0)), "5", Position.Developer),
        };

        public static List<Employee> GetEmployees()
        {
            return _allEmployees;
        }

        public static Employee GetEmployeeByOib(string oib)
        {
            foreach (var employee in _allEmployees)
            {
                if (employee.Oib == oib)
                    return employee;
            }
            return null;
        }

        public static bool TryAdd(string name, string lastName, DateTime dateOfBirth, string oib, Position position)
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

using System;
using System.Collections.Generic;
using Employees.Data.Enums;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class EmployeeRepo
    {
        private static readonly List<Employee> AllEmployees = new List<Employee>()
        {
            new Employee("Stipe", "Stipic", DateTime.Now.Subtract(new TimeSpan(366*20, 0, 0, 0)), "12345678901", Position.Developer),
            new Employee("Mate", "Matic", DateTime.Now.Subtract(new TimeSpan(366*29, 0, 0, 0)), "12345678902", Position.Designer),
            new Employee("Ante", "Antic", DateTime.Now.Subtract(new TimeSpan(366*24, 0, 0, 0)), "12345678903", Position.ProjectManager),
            new Employee("Marija", "Maric", DateTime.Now.Subtract(new TimeSpan(366*26, 0, 0, 0)), "12345678904", Position.Slicer),
            new Employee("Boris", "Boric", DateTime.Now.Subtract(new TimeSpan(366*32, 0, 0, 0)), "12345678905", Position.Developer),
        };

        public static List<Employee> GetEmployees()
        {
            return AllEmployees;
        }

        public static Employee GetEmployeeByOib(string oib)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return employee;
            }
            return null;
        }

        public static bool TryAdd(string name, string lastName, DateTime dateOfBirth, string oib, Position position)
        {
            foreach (var employee in AllEmployees)
            {
                if (employee.Oib == oib)
                    return false;
            }
            var newEmployee = new Employee(name, lastName, dateOfBirth, oib, position);
            AllEmployees.Add(newEmployee);
            return true;
        }

        public static void Remove(Employee toRemove)
        {
            AllEmployees.Remove(toRemove);
        }
    }
}

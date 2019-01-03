﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public class EmployeeRepo
    {
        private static List<Employee> _allEmployees = new List<Employee>();

        public EmployeeRepo()
        {
            var newEmployee = new Employee("Stipe", "Stipic", DateTime.Now, 1, "Test");
            _allEmployees.Add(newEmployee);
        }

        public List<Employee> GetEmployees()
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

        public bool TryAdd(string name, string lastName, DateTime dateOfBirth, int oib, string position)
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
    }
}

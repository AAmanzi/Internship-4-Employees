using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Enums;

namespace Employees.Data.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Oib { get; set; }
        public Position Position { get; set; }

        public Employee(string name, string lastName, DateTime dateOfBirth, string oib, Position position)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Position = position;
        }

        public override string ToString()
        {
            return (
                $"OIB: {Oib} - {Name} {LastName} - {Position} - Date of Birth: {DateOfBirth:dd/MM/yyyy}"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Oib { get; set; }
        public string Position { get; set; }

        public Employee(string name, string lastName, DateTime dateOfBirth, int oib, string position)
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
                $"OIB: {Oib} - {Name} {LastName} - {Position} - Date of Birth: {DateOfBirth:MM/dd/yyyy}"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Models
{
    public class Project
    {
        public string Name { get; set; }
        public DateTime StartOfProject { get; set; }
        public DateTime EndOfProject { get; set; }

        public Project(string name, DateTime startOfProject, DateTime endOfProject)
        {
            Name = name;
            StartOfProject = startOfProject;
            EndOfProject = endOfProject;
        }
    }
}

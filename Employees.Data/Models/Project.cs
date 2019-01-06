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

        public bool HasStarted()
        {
            return StartOfProject.Date <= DateTime.Now.Date;
        }

        public bool HasEnded()
        {
            return EndOfProject.Date <= DateTime.Now.Date;
        }

        public override string ToString()
        {
            return (
                $"{Name} - Start of project: {StartOfProject:dd/MM/yyyy} - End of project: {EndOfProject:dd/MM/yyyy}"
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public class ProjectRepo
    {
        private static List<Project> _allProjects = new List<Project>();

        public ProjectRepo()
        {
            var newProject = new Project("ARK", DateTime.Now, DateTime.Now.AddDays(10));
            _allProjects.Add(newProject);
        }

        public List<Project> GetProjects()
        {
            return _allProjects;
        }

        public static Project GetProjectByName(string name)
        {
            foreach (var project in _allProjects)
            {
                if (project.Name == name)
                    return project;
            }
            return null;
        }
    }
}

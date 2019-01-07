using System;
using System.Collections.Generic;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class ProjectRepo
    {
        private static readonly List<Project> AllProjects = new List<Project>()
        {
            new Project("Ark", DateTime.Now, DateTime.Now.AddDays(10)),
            new Project("Github", DateTime.Now, DateTime.Now.AddDays(16)),
            new Project("Edge", DateTime.Now, DateTime.Now.AddDays(25))
        };

        public static List<Project> GetProjects()
        {
            return AllProjects;
        }

        public static Project GetProjectByName(string name)
        {
            foreach (var project in AllProjects)
            {
                if (project.Name == name)
                    return project;
            }
            return null;
        }

        public static bool TryAdd(string name, DateTime startOfProject, DateTime endOfProject)
        {
            foreach (var project in AllProjects)
            {
                if (project.Name == name)
                    return false;
            }
            var newProject = new Project(name, startOfProject, endOfProject);
            AllProjects.Add(newProject);
            return true;
        }

        public static void Remove(Project toRemove)
        {
            AllProjects.Remove(toRemove);
        }
    }
}

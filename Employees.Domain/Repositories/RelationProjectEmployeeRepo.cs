using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class RelationProjectEmployeeRepo
    {
        private static List<RelationProjectEmployee> _allRelations = new List<RelationProjectEmployee>()
        {
            new RelationProjectEmployee("Ark", "1", 10),
            new RelationProjectEmployee("Ark", "4", 15),
            new RelationProjectEmployee("Ark", "5", 15),
            new RelationProjectEmployee("Github", "1", 20),
            new RelationProjectEmployee("Github", "2", 10),
            new RelationProjectEmployee("Github", "3", 15),
            new RelationProjectEmployee("Github", "5", 10),
            new RelationProjectEmployee("Edge", "1", 15),
            new RelationProjectEmployee("Edge", "3", 10),
            new RelationProjectEmployee("Edge", "4", 5),
        };

        public static List<RelationProjectEmployee> GetAllRelations()
        {
            return _allRelations;
        }

        public static RelationProjectEmployee GetRelation(string oib, string nameOfProject)
        {
            foreach (var relation in _allRelations)
            {
                if (relation.Oib == oib && relation.NameOfProject == nameOfProject)
                    return relation;
            }
            return null;
        }

        public static bool TryAdd(string nameOfProject, string oib, int hoursOfWork)
        {
            foreach (var relation in _allRelations)
            {
                if (relation.NameOfProject == nameOfProject && relation.Oib == oib)
                    return false;
            }

            var newRelation = new RelationProjectEmployee(nameOfProject, oib, hoursOfWork);
            _allRelations.Add(newRelation);
            return true;
        }

        public static List<Employee> GetEmployeesOnProject(string nameOfProject)
        {
            var employeesOnProject = new List<Employee>();
            foreach (var relation in _allRelations)
            {
                if(relation.NameOfProject == nameOfProject)
                    employeesOnProject.Add(EmployeeRepo.GetEmployeeByOib(relation.Oib));
            }
            return employeesOnProject;
        }

        public static List<Project> GetProjectsByEmployee(string oib)
        {
            var projectsByEmployee = new List<Project>();
            foreach (var relation in _allRelations)
            {
                if(relation.Oib == oib)
                    projectsByEmployee.Add(ProjectRepo.GetProjectByName(relation.NameOfProject));
            }

            return projectsByEmployee;
        }

        public static int EmployeeThisWeeksWorkHours(string oib)
        {
            var allEmployeeProjects = GetProjectsByEmployee(oib);
            var totalHours = 0;

            foreach (var project in allEmployeeProjects)
            {
                if (DateTime.Compare(project.StartOfProject, DateTime.Now.AddDays(7)) < 0 &&
                    DateTime.Compare(project.EndOfProject, DateTime.Now) > 0)
                    totalHours += GetRelation(oib, project.Name).HoursOfWork;
            }
            return totalHours;
        }

        public static bool IsEmployeeOnProject(string oib, string projectName)
        {
            var projectsByEmployee = GetProjectsByEmployee(oib);
            foreach (var project in projectsByEmployee)
            {
                if (project.Name == projectName)
                    return true;
            }

            return false;
        }

        public static bool TryRemove(RelationProjectEmployee toRemove)
        {
            foreach (var project in GetProjectsByEmployee(toRemove.Oib))
            {
                if (GetEmployeesOnProject(project.Name).Count == 1)
                {
                    return false;
                }
            }
            _allRelations.Remove(toRemove);
            return true;
        }

        public static void Remove(RelationProjectEmployee toRemove)
        {
            _allRelations.Remove(toRemove);
        }
    }
}

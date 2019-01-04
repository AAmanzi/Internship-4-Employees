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
            new RelationProjectEmployee("ARK", 1, 15)
        };

        public static List<RelationProjectEmployee> GetAllRelations()
        {
            return _allRelations;
        }

        public static RelationProjectEmployee GetRelation(int oib, string nameOfProject)
        {
            foreach (var relation in _allRelations)
            {
                if (relation.Oib == oib && relation.NameOfProject == nameOfProject)
                    return relation;
            }
            return null;
        }

        public static bool TryAdd(string nameOfProject, int oib, int hoursOfWork)
        {
            foreach (var relation in _allRelations)
            {
                if (relation.NameOfProject == nameOfProject && relation.HoursOfWork == hoursOfWork)
                    return false;
            }

            if (EmployeeRepo.GetEmployeeByOib(oib) == null)
                return false;
            if (ProjectRepo.GetProjectByName(nameOfProject) == null)
                return false;

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

        public static List<Project> GetProjectsByEmployee(int oib)
        {
            var projectsByEmployee = new List<Project>();
            foreach (var relation in _allRelations)
            {
                if(relation.Oib == oib)
                    projectsByEmployee.Add(ProjectRepo.GetProjectByName(relation.NameOfProject));
            }

            return projectsByEmployee;
        }

        public static int EmployeeThisWeeksWorkHours(int oib)
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

        public static void Remove(RelationProjectEmployee toRemove)
        {
            _allRelations.Remove(toRemove);
        }
    }
}

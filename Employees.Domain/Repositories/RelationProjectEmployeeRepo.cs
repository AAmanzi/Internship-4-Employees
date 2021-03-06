﻿using System;
using System.Collections.Generic;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    public static class RelationProjectEmployeeRepo
    {
        private static readonly List<RelationProjectEmployee> AllRelations = new List<RelationProjectEmployee>()
        {
            new RelationProjectEmployee("Ark", "12345678901", 10),
            new RelationProjectEmployee("Ark", "12345678904", 15),
            new RelationProjectEmployee("Ark", "12345678905", 15),
            new RelationProjectEmployee("Github", "12345678901", 20),
            new RelationProjectEmployee("Github", "12345678902", 10),
            new RelationProjectEmployee("Github", "12345678903", 15),
            new RelationProjectEmployee("Github", "12345678905", 10),
            new RelationProjectEmployee("Edge", "12345678901", 15),
            new RelationProjectEmployee("Edge", "12345678903", 20),
            new RelationProjectEmployee("Edge", "12345678904", 5),
        };

        public static List<RelationProjectEmployee> GetAllRelations()
        {
            return AllRelations;
        }

        public static RelationProjectEmployee GetRelation(string oib, string nameOfProject)
        {
            foreach (var relation in AllRelations)
            {
                if (relation.Oib == oib && relation.NameOfProject == nameOfProject)
                    return relation;
            }
            return null;
        }

        public static List<Employee> GetEmployeesOnProject(string nameOfProject)
        {
            var employeesOnProject = new List<Employee>();
            foreach (var relation in AllRelations)
            {
                if(relation.NameOfProject == nameOfProject)
                    employeesOnProject.Add(EmployeeRepo.GetEmployeeByOib(relation.Oib));
            }
            return employeesOnProject;
        }

        public static List<Project> GetProjectsByEmployee(string oib)
        {
            var projectsByEmployee = new List<Project>();
            foreach (var relation in AllRelations)
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
            return GetRelation(oib, projectName) != null;
        }

        public static bool TryAdd(string nameOfProject, string oib, int hoursOfWork)
        {
            foreach (var relation in AllRelations)
            {
                if (relation.NameOfProject == nameOfProject && relation.Oib == oib)
                    return false;
            }

            var newRelation = new RelationProjectEmployee(nameOfProject, oib, hoursOfWork);
            AllRelations.Add(newRelation);
            return true;
        }

        public static bool TryRemove(RelationProjectEmployee toRemove)
        {
            if (GetEmployeesOnProject(toRemove.NameOfProject).Count == 1)
            {
                return false;
            }
            AllRelations.Remove(toRemove);
            return true;
        }

        public static void Remove(RelationProjectEmployee toRemove)
        {
            AllRelations.Remove(toRemove);
        }
    }
}

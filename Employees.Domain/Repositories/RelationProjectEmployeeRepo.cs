using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data.Models;

namespace Employees.Domain.Repositories
{
    class RelationProjectEmployeeRepo
    {
        private static List<RelationProjectEmployee> _allRelations = new List<RelationProjectEmployee>();

        public RelationProjectEmployeeRepo()
        {
            var newRelation = new RelationProjectEmployee("ARK", 1, 15);
            _allRelations.Add(newRelation);
        }

        public List<Employee> getEmployeesOnProject(string nameOfProject)
        {
            var employeesOnProject = new List<Employee>();
            foreach (var relation in _allRelations)
            {
                if(relation.NameOfProject == nameOfProject)
                    employeesOnProject.Add(EmployeeRepo.GetEmployeeByOib(relation.Oib));
            }
            return employeesOnProject;
        }

        public List<Project> getProjectsByEmployee(int oib)
        {
            var projectsByEmployee = new List<Project>();
            foreach (var relation in _allRelations)
            {
                if(relation.Oib == oib)
                    projectsByEmployee.Add(ProjectRepo.GetProjectByName(relation.NameOfProject));
            }

            return projectsByEmployee;
        }

    }
}

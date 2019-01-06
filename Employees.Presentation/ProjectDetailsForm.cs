using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Enums;
using Employees.Data.Models;
using Employees.Domain.Repositories;

namespace Employees.Presentation
{
    public partial class ProjectDetailsForm : Form
    {
        private List<Project> ProjectsToShow { get; set; }
        public ProjectDetailsForm(List<Project> projectsToShow)
        {
            ProjectsToShow = projectsToShow;
            InitializeComponent();
            RefreshProjectDetails();
        }

        private void RefreshProjectDetails()
        {
            var detailsText = "";
            foreach (var project in ProjectsToShow)
            {
                detailsText += $"{project.Name}\n{project.StartOfProject:d} - {project.EndOfProject:d}\n\n";
                
                foreach (var position in Enum.GetNames(typeof(Position)))
                {
                    var positionEmployees = new List<Employee>();
                    foreach (var employee in RelationProjectEmployeeRepo.GetEmployeesOnProject(project.Name))
                    {
                        if (employee.Position.ToString() == position)
                            positionEmployees.Add(employee);
                    }

                    if (positionEmployees.Count == 0) continue;

                    detailsText += $"{position} ({positionEmployees.Count})\n";

                    foreach (var employee in positionEmployees)
                    {
                        detailsText +=
                            $"\t{employee.Name} {employee.LastName} ({RelationProjectEmployeeRepo.GetRelation(employee.Oib, project.Name).HoursOfWork})\n";
                    }

                    detailsText += "\n";
                }
                
                detailsText += "\n";
            }

            ProjectDetailsTextBox.Text = detailsText;
        }
    }
}

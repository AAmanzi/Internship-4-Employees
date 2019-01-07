using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation.Forms
{
    public partial class ManageProjectsForm : Form
    {
        public ManageProjectsForm()
        {
            InitializeComponent();
            RefreshProjectsListBox();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshProjectsListBox()
        {
            ProjectListBox.Items.Clear();
            foreach (var project in ProjectRepo.GetProjects())
            {
                ProjectListBox.Items.Add(project);
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            var checkedProjects = new List<Project>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjects.Add(ProjectRepo.GetProjectByName(checkedProjectItem.ToString().GetProjectName()));
            }
            if (checkedProjects.Count == 0)
                return;

            var confirmDeleteProject = new ConfirmForm();
            confirmDeleteProject.ShowDialog();

            if (confirmDeleteProject.IsConfirmed)
            {
                foreach (var project in checkedProjects)
                {
                    ProjectRepo.Remove(project);
                    foreach (var employee in RelationProjectEmployeeRepo.GetEmployeesOnProject(project.Name))
                    {
                        RelationProjectEmployeeRepo.Remove(RelationProjectEmployeeRepo.GetRelation(employee.Oib, project.Name));
                    }
                }
            }

            RefreshProjectsListBox();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            var addProject = new EditProjectForm();
            addProject.ShowDialog();
            RefreshProjectsListBox();
        }

        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            var checkedProjects = new List<Project>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjects.Add(ProjectRepo.GetProjectByName(checkedProjectItem.ToString().GetProjectName()));
            }
            if (checkedProjects.Count == 0)
                return;

            foreach (var project in checkedProjects)
            {
                var editProject = new EditProjectForm(project.Name, project.StartOfProject, project.EndOfProject);
                editProject.ShowDialog();
            }
            RefreshProjectsListBox();
        }
    }
}

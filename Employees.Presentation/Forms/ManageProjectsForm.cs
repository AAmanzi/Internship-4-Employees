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
            if (!confirmDeleteProject.IsConfirmed) return;

            foreach (var project in checkedProjects)
            {
                Delete(project);
            }

            RefreshProjectsListBox();
        }

        private static void Delete(Project toDelete)
        {
            ProjectRepo.Remove(toDelete);
            foreach (var employee in RelationProjectEmployeeRepo.GetEmployeesOnProject(toDelete.Name))
            {
                RelationProjectEmployeeRepo.Remove(RelationProjectEmployeeRepo.GetRelation(employee.Oib, toDelete.Name));
            }
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
                var editProject = new EditProjectForm(project);
                editProject.ShowDialog();
            }
            RefreshProjectsListBox();
        }
    }
}

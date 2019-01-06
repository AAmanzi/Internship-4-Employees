using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation
{
    public partial class AllProjectsInfoForm : Form
    {
        public AllProjectsInfoForm()
        {
            InitializeComponent();
            RefreshProjectsListBox();
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            var manageProjects = new ManageProjectsForm();
            manageProjects.ShowDialog();
            RefreshProjectsListBox();
        }

        private void RefreshProjectsListBox()
        {
            ProjectListBox.Items.Clear();
            foreach (var project in ProjectRepo.GetProjects())
            {
                ProjectListBox.Items.Add(project);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            var checkedProjects = new List<Project>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjects.Add(ProjectRepo.GetProjectByName(checkedProjectItem.ToString().GetProjectName()));
            }
            if (checkedProjects.Count == 0)
                return;

            var projectDetails = new ProjectDetailsForm(checkedProjects);
            projectDetails.ShowDialog();
        }
    }
}

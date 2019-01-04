﻿using System;
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
    public partial class ManageProjectsForm : Form
    {
        public ManageProjectsForm()
        {
            InitializeComponent();
            RefreshProjectsListBox();
        }

        private void ExitButton_Click(object sender, EventArgs e)
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

            if (confirmDeleteProject.isConfirmed)
            {
                foreach (var project in checkedProjects)
                {
                    ProjectRepo.Remove(project);
                }
            }

            RefreshProjectsListBox();
        }
    }
}
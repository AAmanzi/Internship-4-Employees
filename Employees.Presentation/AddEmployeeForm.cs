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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            RefreshProjectsListBox();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.isConfirmed)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(OibTextBox.Text) ||
                string.IsNullOrWhiteSpace(PositionTextBox.Text))
            {
                new ErrorForm("You are missing some required fields!").ShowDialog();
                return;
            }

            //User input checks here

            var checkedProjectNames = new List<string>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjectNames.Add(checkedProjectItem.ToString().GetProjectName());
            }

            foreach (var projectName in checkedProjectNames)
            {
                var addHours = new AddHoursForm(projectName, NameTextBox.Text, true);
                addHours.ShowDialog();
                RelationProjectEmployeeRepo.TryAdd(projectName, OibTextBox.Text, addHours.HoursToAdd);
            }

            EmployeeRepo.TryAdd(NameTextBox.Text, LastNameTextBox.Text, DateOfBirthPicker.Value, OibTextBox.Text, PositionTextBox.Text);
            Close();
        }

        private void OibTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void PositionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}

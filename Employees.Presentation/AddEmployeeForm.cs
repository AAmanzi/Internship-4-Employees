using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation
{
    public partial class AddEmployeeForm : Form
    {
        public string OldOib { get; set; }
        public bool IsAdd { get; set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
            DateOfBirthPicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18 + 4, 0, 0, 0));
            RefreshProjectsListBox();
            IsAdd = true;
        }

        public AddEmployeeForm(string name, string lastName, DateTime dateOfBirth, string oib, string position)
        {
            OldOib = oib;
            IsAdd = false;

            InitializeComponent();
            AddEmployeeLabel.Text = @"Edit Employee";
            NameTextBox.Text = name;
            LastNameTextBox.Text = lastName;
            DateOfBirthPicker.Value = dateOfBirth;
            OibTextBox.Text = oib;
            PositionTextBox.Text = position;
            RefreshProjectsListBox();
            CheckProjectsByEmployee(oib);
        }

        private void RefreshProjectsListBox()
        {
            ProjectListBox.Items.Clear();
            foreach (var project in ProjectRepo.GetProjects())
            {
                ProjectListBox.Items.Add(project);
            }
        }

        private void CheckProjectsByEmployee(string employeeOib)
        {
            foreach (var project in RelationProjectEmployeeRepo.GetProjectsByEmployee(employeeOib))
            {
                for (var i = 0; i < ProjectListBox.Items.Count; i++)
                {
                    if (ProjectListBox.Items[i].ToString().GetProjectName() != project.ToString().GetProjectName()) continue;
                    ProjectListBox.SetItemChecked(i, true);
                    break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.isConfirmed)
                Close();
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

            if (IsAdd)
            {
                OldOib = OibTextBox.Text;
                if (EmployeeRepo.GetEmployeeByOib(OldOib) != null)
                {
                    var existingEmployeeError = new ErrorForm("An employee with that oib already exists!");
                    existingEmployeeError.ShowDialog();
                    return;
                }
            }
            else
            {
                if (OldOib != OibTextBox.Text && EmployeeRepo.GetEmployeeByOib(OibTextBox.Text) != null)
                {
                    var existingEmployeeError = new ErrorForm("An employee with that oib already exists!");
                    existingEmployeeError.ShowDialog();
                    return;
                }
            }

            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            LastNameTextBox.Text = LastNameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            PositionTextBox.Text = PositionTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();

            var checkedProjectNames = new List<string>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjectNames.Add(checkedProjectItem.ToString().GetProjectName());
            }

            foreach (var projectItem in ProjectListBox.Items)
            {
                if (ProjectListBox.CheckedItems.Contains(projectItem)) continue;
                if (RelationProjectEmployeeRepo.IsEmployeeOnProject(OldOib, projectItem.ToString().GetProjectName()))
                {
                    RelationProjectEmployeeRepo.TryRemove(
                        RelationProjectEmployeeRepo.GetRelation(OldOib, projectItem.ToString().GetProjectName()));
                }
            }

            foreach (var projectName in checkedProjectNames)
            {
                if (RelationProjectEmployeeRepo.IsEmployeeOnProject(OldOib, projectName)) continue;
                var addHours = new AddHoursForm(projectName, NameTextBox.Text, true);
                addHours.ShowDialog();
                RelationProjectEmployeeRepo.TryAdd(projectName, OldOib, addHours.HoursToAdd);
            }

            EmployeeRepo.Remove(EmployeeRepo.GetEmployeeByOib(OldOib));
            foreach (var relation
                in RelationProjectEmployeeRepo.GetAllRelations())
            {
                if (relation.Oib == OldOib)
                {
                    relation.Oib = OibTextBox.Text;
                }
            }
            EmployeeRepo.TryAdd(NameTextBox.Text, LastNameTextBox.Text, DateOfBirthPicker.Value, OibTextBox.Text,
                PositionTextBox.Text);

            Close();
        }

        //Key disables
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

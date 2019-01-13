using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Enums;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation.Forms
{
    public partial class EditEmployeeForm : Form
    {
        public string OldOib { get; set; }
        public bool IsAdd { get; set; }

        public EditEmployeeForm()
        {
            InitializeComponent();
            AddEmployeeLabel.Text = @"Add Employee";
            DateOfBirthPicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18 + 4, 0, 0, 0));
            RefreshProjectsListBox();
            RefreshPositionComboBox();
            IsAdd = true;
        }

        public EditEmployeeForm(Employee toEdit)
        {
            OldOib = toEdit.Oib;
            IsAdd = false;

            InitializeComponent();
            NameTextBox.Text = toEdit.Name;
            LastNameTextBox.Text = toEdit.LastName;
            DateOfBirthPicker.Value = toEdit.DateOfBirth;
            DateOfBirthPicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18 + 4, 0, 0, 0));
            OibTextBox.Text = toEdit.Oib;
            RefreshPositionComboBox();
            PositionComboBox.Text = toEdit.Position.ToString();
            RefreshProjectsListBox();
            CheckProjectsByEmployee(toEdit.Oib);
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

        private void RefreshPositionComboBox()
        {
            var positionNames = Enum.GetNames(typeof(Position));
            foreach (var position in positionNames)
            {
                PositionComboBox.Items.Add(position);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.IsConfirmed)
                Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckForErrors()) return;

            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            LastNameTextBox.Text = LastNameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();

            var checkedProjectNames = new List<string>();
            foreach (var checkedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjectNames.Add(checkedProjectItem.ToString().GetProjectName());
            }

            if(!TryRemoveUncheckedProjects()) return;
            AddProjectsToEmployee(checkedProjectNames);

            EmployeeRepo.Remove(EmployeeRepo.GetEmployeeByOib(OldOib));
            UpdateOib();

            EmployeeRepo.TryAdd(NameTextBox.Text, LastNameTextBox.Text, DateOfBirthPicker.Value, OibTextBox.Text,
                (Position)Enum.Parse(typeof(Position), PositionComboBox.Text));

            Close();
        }

        private void UpdateOib()
        {
            foreach (var relation
                in RelationProjectEmployeeRepo.GetAllRelations())
            {
                if (relation.Oib == OldOib)
                {
                    relation.Oib = OibTextBox.Text;
                }
            }
        }

        private bool TryRemoveUncheckedProjects()
        {
            foreach (var projectItem in ProjectListBox.Items)
            {
                if (ProjectListBox.CheckedItems.Contains(projectItem)) continue;
                if (!RelationProjectEmployeeRepo.IsEmployeeOnProject(OldOib, projectItem.ToString().GetProjectName())
                ) continue;
                if (RelationProjectEmployeeRepo.TryRemove(
                    RelationProjectEmployeeRepo.GetRelation(OldOib, projectItem.ToString().GetProjectName())))
                    continue;
                var lastEmployeeError = new ErrorForm($"{NameTextBox.Text} could not be removed from project {projectItem.ToString().GetProjectName()}\n" +
                                                      "He is the last employee on that project");
                lastEmployeeError.ShowDialog();
                return false;
            }
            return true;
        }

        private void AddProjectsToEmployee(IEnumerable<string> projectNameListSource)
        {
            foreach (var projectName in projectNameListSource)
            {
                if (RelationProjectEmployeeRepo.IsEmployeeOnProject(OldOib, projectName)) continue;
                var addHours = new AddHoursForm(projectName, NameTextBox.Text, true);
                addHours.ShowDialog();
                if (addHours.HoursToAdd == 0)
                {
                    var hoursError =
                        new ErrorForm(
                            $"Project {projectName} could not be added!\nAn employee cannot work 0 hours on a project!");
                    hoursError.ShowDialog();
                    continue;
                }
                RelationProjectEmployeeRepo.TryAdd(projectName, OldOib, addHours.HoursToAdd);
            }
        }

        private bool CheckForErrors()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(OibTextBox.Text) ||
                string.IsNullOrWhiteSpace(PositionComboBox.Text))
            {
                new ErrorForm("You are missing some required fields!").ShowDialog();
                return true;
            }

            if (!OibTextBox.Text.IsOibValid())
            {
                new ErrorForm("That is not a valid OIB!").ShowDialog();
                return true;
            }

            if (IsAdd)
            {
                OldOib = OibTextBox.Text;
                if (EmployeeRepo.GetEmployeeByOib(OldOib) == null) return false;
                var existingEmployeeError = new ErrorForm("An employee with that OIB already exists!");
                existingEmployeeError.ShowDialog();
                return true;
            }
            else
            {
                if (OldOib == OibTextBox.Text || EmployeeRepo.GetEmployeeByOib(OibTextBox.Text) == null) return false;
                var existingEmployeeError = new ErrorForm("An employee with that OIB already exists!");
                existingEmployeeError.ShowDialog();
                return true;
            }
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
    }
}

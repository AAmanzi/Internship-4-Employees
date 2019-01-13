using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation.Forms
{
    public partial class EditProjectForm : Form
    {
        public string OldName { get; set; }
        public bool IsAdd { get; set; }
        private readonly List<string> _checkedEmployeesOibList = new List<string>();
        public EditProjectForm()
        {
            InitializeComponent();
            AddProjectLabel.Text = @"Add Project";
            EndDatePicker.Value = StartDatePicker.Value.AddDays(1);
            RefreshEmployeesListBox();
            IsAdd = true;
        }

        public EditProjectForm(Project toEdit)
        {
            OldName = toEdit.Name;

            InitializeComponent();
            NameTextBox.Text = toEdit.Name;
            StartDatePicker.Value = toEdit.StartOfProject;
            EndDatePicker.Value = toEdit.EndOfProject;
            RefreshEmployeesListBox();
            CheckEmployeesOnProject(toEdit.Name);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.IsConfirmed)
                Close();
        }

        private void RefreshEmployeesListBox()
        {
            EmployeeListBox.Items.Clear();
            foreach (var employee in EmployeeRepo.GetEmployees())
            {
                EmployeeListBox.Items.Add(employee);
            }
        }

        private void CheckEmployeesOnProject(string projectName)
        {
            foreach (var employee in RelationProjectEmployeeRepo.GetEmployeesOnProject(projectName))
            {
                for (var i = 0; i < EmployeeListBox.Items.Count; i++)
                {
                    if (EmployeeListBox.Items[i].ToString().GetOib() != employee.ToString().GetOib()) continue;
                    EmployeeListBox.SetItemChecked(i, true);
                    break;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().FirstLetterToUpper();
            
            foreach (var checkedEmployeeItem in EmployeeListBox.CheckedItems)
            {
                _checkedEmployeesOibList.Add(checkedEmployeeItem.ToString().GetOib());
            }

            if(CheckForErrors()) return;

            AddEmployeesToProject();
            if (CheckForErrors()) return;

            RemoveUncheckedEmployees();

            ProjectRepo.Remove(ProjectRepo.GetProjectByName(OldName));
            UpdateProjectName();

            ProjectRepo.TryAdd(NameTextBox.Text, StartDatePicker.Value, EndDatePicker.Value);
            Close();
        }

        private void RemoveUncheckedEmployees()
        {
            foreach (var employeeItem in EmployeeListBox.Items)
            {
                if (EmployeeListBox.CheckedItems.Contains(employeeItem)) continue;
                if (RelationProjectEmployeeRepo.IsEmployeeOnProject(employeeItem.ToString().GetOib(),
                    OldName))
                {
                    RelationProjectEmployeeRepo.Remove(
                        RelationProjectEmployeeRepo.GetRelation(employeeItem.ToString().GetOib(),
                            OldName));
                }
            }
        }

        private void AddEmployeesToProject()
        {
            var employeesToUncheck = new List<string>();
            foreach (var employeeOib in _checkedEmployeesOibList)
            {
                if (RelationProjectEmployeeRepo.IsEmployeeOnProject(employeeOib, OldName)) continue;
                var addHours = new AddHoursForm(NameTextBox.Text, EmployeeRepo.GetEmployeeByOib(employeeOib).Name, false);
                addHours.ShowDialog();
                if (addHours.HoursToAdd == 0)
                {
                    var hoursError =
                        new ErrorForm(
                            $"Employee {EmployeeRepo.GetEmployeeByOib(employeeOib).Name} could not be added!\nAn employee cannot work 0 hours on a project!");
                    hoursError.ShowDialog();
                    employeesToUncheck.Add(employeeOib);
                    continue;
                }
                RelationProjectEmployeeRepo.TryAdd(OldName, employeeOib, addHours.HoursToAdd);
            }
            UncheckEmployees(employeesToUncheck);
        }

        private void UncheckEmployees(IEnumerable<string> oibList)
        {
            foreach (var oib in oibList)
            {
                _checkedEmployeesOibList.Remove(oib);
            }
        }

        private void UpdateProjectName()
        {
            foreach (var relation
                in RelationProjectEmployeeRepo.GetAllRelations())
            {
                if (relation.NameOfProject == OldName)
                {
                    relation.NameOfProject = NameTextBox.Text;
                }
            }
        }

        private bool CheckForErrors()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                new ErrorForm("You are missing some required fields!").ShowDialog();
                return true;
            }

            if (_checkedEmployeesOibList.Count == 0)
            {
                new ErrorForm("A project must have at least one employee!").ShowDialog();
                return true;
            }

            if (IsAdd)
            {
                OldName = NameTextBox.Text;
                if (ProjectRepo.GetProjectByName(OldName) != null)
                {
                    var existingProjectError = new ErrorForm("A project with that name already exists!");
                    existingProjectError.ShowDialog();
                    return true;
                }
            }
            else
            {
                if (OldName != NameTextBox.Text && ProjectRepo.GetProjectByName(NameTextBox.Text) != null)
                {
                    var existingProjectError = new ErrorForm("A project with that name already exists!");
                    existingProjectError.ShowDialog();
                    return true;
                }
            }

            if (StartDatePicker.Value <= EndDatePicker.Value) return false;
            var dateError = new ErrorForm("A project cannot end before it has started!");
            dateError.ShowDialog();
            return true;
        }

        //Key disables
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}

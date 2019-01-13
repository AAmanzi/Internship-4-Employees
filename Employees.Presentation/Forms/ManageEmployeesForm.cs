using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Models;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation.Forms
{
    public partial class ManageEmployeesForm : Form
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();
            RefreshEmployeesListBox();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
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

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            var checkedEmployees = new List<Employee>();
            foreach (var checkedEmployeeItem in EmployeeListBox.CheckedItems)
            {
                checkedEmployees.Add(EmployeeRepo.GetEmployeeByOib(checkedEmployeeItem.ToString().GetOib()));
            }
            if (checkedEmployees.Count == 0)
                return;

            var confirmDeleteEmployee = new ConfirmForm();
            confirmDeleteEmployee.ShowDialog();
            if (!confirmDeleteEmployee.IsConfirmed) return;

            foreach (var employee in checkedEmployees)
            {
                TryDelete(employee);
            }

            RefreshEmployeesListBox();
        }

        private static void TryDelete(Employee toRemove)
        {
            var errorCount = 0;
            foreach (var project in RelationProjectEmployeeRepo.GetProjectsByEmployee(toRemove.Oib))
            {
                if (RelationProjectEmployeeRepo.TryRemove(
                    RelationProjectEmployeeRepo.GetRelation(toRemove.Oib, project.Name))) continue;
                errorCount++;
                var lastEmployeeOnProjectError = new ErrorForm($"Employee {toRemove.Name} {toRemove.LastName} could not be deleted!\nHe is the last employee on one or more projects!");
                lastEmployeeOnProjectError.ShowDialog();
                break;
            }
            if (errorCount == 0)
                EmployeeRepo.Remove(toRemove);
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new EditEmployeeForm();
            addEmployee.ShowDialog();
            RefreshEmployeesListBox();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            var checkedEmployees = new List<Employee>();
            foreach (var checkedEmployeeItem in EmployeeListBox.CheckedItems)
            {
                checkedEmployees.Add(EmployeeRepo.GetEmployeeByOib(checkedEmployeeItem.ToString().GetOib()));
            }
            if (checkedEmployees.Count == 0)
                return;

            foreach (var employee in checkedEmployees)
            {
                var editProject = new EditEmployeeForm(employee);
                editProject.ShowDialog();
            }

            RefreshEmployeesListBox();
        }
    }
}

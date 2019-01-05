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
    public partial class ManageEmployeesForm : Form
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();
            RefreshEmployeesListBox();
        }

        private void ExitButton_Click(object sender, EventArgs e)
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

            if (confirmDeleteEmployee.isConfirmed)
            {
                foreach (var employee in checkedEmployees)
                {
                    var errorCount = 0;
                    foreach (var project in RelationProjectEmployeeRepo.GetProjectsByEmployee(employee.Oib))
                    {
                        if (RelationProjectEmployeeRepo.TryRemove(
                            RelationProjectEmployeeRepo.GetRelation(employee.Oib, project.Name))) continue;
                        errorCount++;
                        var lastEmployeeOnProjectError = new ErrorForm($"Employee {employee.Name} {employee.LastName} could not be deleted!\nHe is the last employee on one or more projects!");
                        lastEmployeeOnProjectError.ShowDialog();
                        break;
                    }
                    if (errorCount == 0)
                        EmployeeRepo.Remove(employee);
                }
            }

            RefreshEmployeesListBox();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm();
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
                var editProject = new AddEmployeeForm(employee.Name, employee.LastName, employee.DateOfBirth, employee.Oib, employee.Position);
                editProject.ShowDialog();
            }

            RefreshEmployeesListBox();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Domain.Repositories;
using Employees.Infrastructure.Extensions;

namespace Employees.Presentation
{
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
            RefreshEmployeesListBox();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.isConfirmed)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                new ErrorForm("You are missing some required fields!").ShowDialog();
                return;
            }

            var checkedEmployeeOibList = new List<string>();
            foreach (var checkedEmployeeItem in EmployeeListBox.CheckedItems)
            {
                checkedEmployeeOibList.Add(checkedEmployeeItem.ToString().GetOib());
            }
            if (checkedEmployeeOibList.Count == 0)
            {
                new ErrorForm("A project must have at least one employee!").ShowDialog();
                return;
            }

            foreach (var employeeOib in checkedEmployeeOibList)
            {
                var addHours = new AddHoursForm(NameTextBox.Text, EmployeeRepo.GetEmployeeByOib(employeeOib).Name, false);
                addHours.ShowDialog();
                RelationProjectEmployeeRepo.TryAdd(NameTextBox.Text, employeeOib, addHours.HoursToAdd);
            }

            ProjectRepo.TryAdd(NameTextBox.Text, StartDatePicker.Value, EndDatePicker.Value);
            Close();
        }

        //Key disables
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}

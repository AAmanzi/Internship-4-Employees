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

            var ConfirmDeleteEmployee = new ConfirmForm();
            ConfirmDeleteEmployee.ShowDialog();

            if (ConfirmDeleteEmployee.isConfirmed)
            {
                foreach (var employee in checkedEmployees)
                {
                    EmployeeRepo.Remove(employee);
                }
            }
            RefreshEmployeesListBox();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

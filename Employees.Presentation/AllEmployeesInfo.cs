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

namespace Employees.Presentation
{
    public partial class AllEmployeesInfo : Form
    {
        public AllEmployeesInfo()
        {
            InitializeComponent();
            RefreshEmployeeInfo();
        }

        private void RefreshEmployeeInfo()
        {
            EmployeeInfoListView.Items.Clear();

            EmployeeInfoListView.Columns.Add("Name", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Last name", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Date of birth", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("OIB", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Position", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Work hours this week", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Ended projects", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Active projects", -2, HorizontalAlignment.Left);
            EmployeeInfoListView.Columns.Add("Upcoming projects", -2, HorizontalAlignment.Left);

            foreach (var employee in EmployeeRepo.GetEmployees())
            {
                var employeeItem = new ListViewItem(employee.Name);

                if (RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(employee.Oib) > 40)
                    employeeItem.BackColor = Color.DarkSlateGray;
                else if(RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(employee.Oib) < 30)
                    employeeItem.BackColor = Color.Goldenrod;
                else
                    employeeItem.BackColor = Color.Aquamarine;

                employeeItem.SubItems.Add(employee.LastName);
                employeeItem.SubItems.Add($"{employee.DateOfBirth:d}");
                employeeItem.SubItems.Add(employee.Oib);
                employeeItem.SubItems.Add(employee.Position.ToString());
                employeeItem.SubItems.Add(RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(employee.Oib).ToString());

                var projectsEnded = 0;
                var projectsActive = 0;
                var projectsUpcoming = 0;
                foreach (var project in RelationProjectEmployeeRepo.GetProjectsByEmployee(employee.Oib))
                {
                    if (project.HasEnded())
                        projectsEnded++;
                    if (project.HasStarted() && !project.HasEnded())
                        projectsActive++;
                    if (!project.HasStarted())
                        projectsUpcoming++;
                }

                employeeItem.SubItems.Add(projectsEnded.ToString());
                employeeItem.SubItems.Add(projectsActive.ToString());
                employeeItem.SubItems.Add(projectsUpcoming.ToString());

                EmployeeInfoListView.Items.Add(employeeItem);
            }
            
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            var manageEmployees = new ManageEmployeesForm();
            manageEmployees.ShowDialog();
            RefreshEmployeeInfo();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

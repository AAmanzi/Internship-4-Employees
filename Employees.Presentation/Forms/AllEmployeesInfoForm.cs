using System;
using System.Drawing;
using System.Windows.Forms;
using Employees.Data.Models;
using Employees.Domain.Repositories;

namespace Employees.Presentation.Forms
{
    public partial class AllEmployeesInfoForm : Form
    {
        public AllEmployeesInfoForm()
        {
            InitializeComponent();
            RefreshEmployeeInfo();
        }

        private void RefreshEmployeeInfo()
        {
            EmployeeInfoListView.Items.Clear();
            AddEmployeeColumns(EmployeeInfoListView);

            foreach (var employee in EmployeeRepo.GetEmployees())
            {
                var employeeItem = new ListViewItem(employee.Name);
                SetEmployeeBackColor(employeeItem, employee);
                AddEmployeeSubItems(employeeItem, employee);
                SetEmployeeProjects(employeeItem, employee);

                EmployeeInfoListView.Items.Add(employeeItem);
            }
        }

        private static void AddEmployeeColumns(ListView destination)
        {
            destination.Columns.Add("Name", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Last name", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Date of birth", -2, HorizontalAlignment.Left);
            destination.Columns.Add("OIB", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Position", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Work hours this week", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Ended projects", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Active projects", -2, HorizontalAlignment.Left);
            destination.Columns.Add("Upcoming projects", -2, HorizontalAlignment.Left);
        }

        private static void AddEmployeeSubItems(ListViewItem destination, Employee source)
        {
            destination.SubItems.Add(source.LastName);
            destination.SubItems.Add($"{source.DateOfBirth:d}");
            destination.SubItems.Add(source.Oib);
            destination.SubItems.Add(source.Position.ToString());
            destination.SubItems.Add(RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(source.Oib).ToString());
        }

        private static void SetEmployeeBackColor(ListViewItem destination, Employee hoursSource)
        {

            if (RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(hoursSource.Oib) > 40)
                destination.BackColor = Color.Red;
            else if (RelationProjectEmployeeRepo.EmployeeThisWeeksWorkHours(hoursSource.Oib) < 30)
                destination.BackColor = Color.Goldenrod;
            else
                destination.BackColor = Color.MediumSeaGreen;
        }

        private static void SetEmployeeProjects(ListViewItem destination, Employee projectSource)
        {
            var projectsEnded = 0;
            var projectsActive = 0;
            var projectsUpcoming = 0;
            foreach (var project in RelationProjectEmployeeRepo.GetProjectsByEmployee(projectSource.Oib))
            {
                if (project.HasEnded())
                    projectsEnded++;
                if (project.HasStarted() && !project.HasEnded())
                    projectsActive++;
                if (!project.HasStarted())
                    projectsUpcoming++;
            }

            destination.SubItems.Add(projectsEnded.ToString());
            destination.SubItems.Add(projectsActive.ToString());
            destination.SubItems.Add(projectsUpcoming.ToString());
        }

        //buttons
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

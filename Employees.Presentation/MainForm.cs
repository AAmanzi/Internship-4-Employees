using System;
using System.Windows.Forms;
using Employees.Presentation.Forms;

namespace Employees.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ManageEmployeesButton_Click(object sender, EventArgs e)
        {
            var manageEmployees = new ManageEmployeesForm();
            manageEmployees.ShowDialog();
        }

        private void ManageProjectsButton_Click(object sender, EventArgs e)
        {
            var manageProjects = new ManageProjectsForm();
            manageProjects.ShowDialog();
        }

        private void ViewProjectsInfoButton_Click(object sender, EventArgs e)
        {
            var allProjectsInfo = new AllProjectsInfoForm();
            allProjectsInfo.ShowDialog();
        }

        private void ViewEmployeesButton_Click(object sender, EventArgs e)
        {
            var allEmployeesInfo = new AllEmployeesInfoForm();
            allEmployeesInfo.ShowDialog();
        }
    }
}

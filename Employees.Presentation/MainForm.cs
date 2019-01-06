using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var allEmployeesInfo = new AllEmployeesInfo();
            allEmployeesInfo.ShowDialog();
        }
    }
}

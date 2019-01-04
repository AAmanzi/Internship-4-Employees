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
    public partial class AddHoursForm : Form
    {
        public int HoursToAdd { get; set; }
        public AddHoursForm(string projectName, string employeeName, bool isAddEmployee)
        {
            InitializeComponent();
            if (isAddEmployee)
            {
                Text = employeeName;
                NameLabel.Text = projectName;
                AddHoursLabel.Text = @"Add hours to project";
            }
            else
            {
                Text = projectName;
                NameLabel.Text = employeeName;
                AddHoursLabel.Text = @"Add hours to employee";
            }
            HoursToAdd = 0;
        }

        private void HoursToAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            HoursToAdd = int.Parse(HoursTextBox.Text);
            Close();
        }
    }
}

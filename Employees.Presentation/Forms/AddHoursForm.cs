using System;
using System.Windows.Forms;

namespace Employees.Presentation.Forms
{
    public partial class AddHoursForm : Form
    {
        public int HoursToAdd { get; set; }
        public AddHoursForm(string projectName, string employeeName, bool isAddingToProject)
        {
            InitializeComponent();
            if (isAddingToProject)
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

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void HoursToAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HoursTextBox.Text))
                HoursToAdd = int.Parse(HoursTextBox.Text);
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Employees.Presentation.Forms
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        public ErrorForm(string errorMessage)
        {
            InitializeComponent();
            ErrorLabel.Text = errorMessage;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

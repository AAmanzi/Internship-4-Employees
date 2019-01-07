using System;
using System.Windows.Forms;

namespace Employees.Presentation.Forms
{
    public partial class ConfirmForm : Form
    {
        public bool IsConfirmed;
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void ConfirmYesButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            Close();
        }

        private void ConfirmNoButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            Close();
        }
    }
}

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

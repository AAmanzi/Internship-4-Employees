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
    public partial class ConfirmForm : Form
    {
        public bool isConfirmed;
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void ConfirmYesButton_Click(object sender, EventArgs e)
        {
            isConfirmed = true;
            Close();
        }

        private void ConfirmNoButton_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            Close();
        }
    }
}

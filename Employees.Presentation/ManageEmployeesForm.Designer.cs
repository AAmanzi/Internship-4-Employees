namespace Employees.Presentation
{
    partial class ManageEmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(549, 49);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Add new employee";
            this.AddEmployeeButton.UseMnemonic = false;
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(549, 132);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.EditEmployeeButton.TabIndex = 2;
            this.EditEmployeeButton.Text = "Edit selected";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(549, 217);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.DeleteEmployeeButton.TabIndex = 3;
            this.DeleteEmployeeButton.Text = "Delete selected";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(45, 49);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(422, 334);
            this.EmployeeListBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(672, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployeesForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.CheckedListBox EmployeeListBox;
        private System.Windows.Forms.Button button1;
    }
}
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.Location = new System.Drawing.Point(49, 40);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(469, 355);
            this.EmployeesListBox.TabIndex = 0;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(549, 40);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Add new employee";
            this.AddEmployeeButton.UseMnemonic = false;
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(549, 194);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.EditEmployeeButton.TabIndex = 2;
            this.EditEmployeeButton.Text = "Edit selected";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(549, 343);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(227, 52);
            this.DeleteEmployeeButton.TabIndex = 3;
            this.DeleteEmployeeButton.Text = "Delete selected";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeesListBox);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployeesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
    }
}
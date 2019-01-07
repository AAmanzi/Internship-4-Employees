namespace Employees.Presentation.Forms
{
    partial class AllEmployeesInfoForm
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
            this.ManageButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EmployeeInfoListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ManageButton
            // 
            this.ManageButton.BackColor = System.Drawing.Color.MintCream;
            this.ManageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.Location = new System.Drawing.Point(1182, 276);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(103, 52);
            this.ManageButton.TabIndex = 9;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = false;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1182, 368);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 52);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EmployeeInfoListView
            // 
            this.EmployeeInfoListView.BackColor = System.Drawing.Color.LightCyan;
            this.EmployeeInfoListView.CausesValidation = false;
            this.EmployeeInfoListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInfoListView.GridLines = true;
            this.EmployeeInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EmployeeInfoListView.Location = new System.Drawing.Point(4, 1);
            this.EmployeeInfoListView.MultiSelect = false;
            this.EmployeeInfoListView.Name = "EmployeeInfoListView";
            this.EmployeeInfoListView.Size = new System.Drawing.Size(1139, 452);
            this.EmployeeInfoListView.TabIndex = 11;
            this.EmployeeInfoListView.UseCompatibleStateImageBehavior = false;
            this.EmployeeInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // AllEmployeesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1317, 450);
            this.Controls.Add(this.EmployeeInfoListView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ManageButton);
            this.Name = "AllEmployeesInfo";
            this.Text = "AllEmployeesInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView EmployeeInfoListView;
    }
}
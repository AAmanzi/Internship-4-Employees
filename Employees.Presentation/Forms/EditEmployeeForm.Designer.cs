namespace Employees.Presentation.Forms
{
    partial class EditEmployeeForm
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
            this.AddEmployeeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.OibLabel = new System.Windows.Forms.Label();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProjectListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddEmployeeLabel
            // 
            this.AddEmployeeLabel.AutoSize = true;
            this.AddEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeLabel.Location = new System.Drawing.Point(164, 23);
            this.AddEmployeeLabel.Name = "AddEmployeeLabel";
            this.AddEmployeeLabel.Size = new System.Drawing.Size(188, 31);
            this.AddEmployeeLabel.TabIndex = 0;
            this.AddEmployeeLabel.Text = "Edit Employee";
            this.AddEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(52, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.Azure;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(128, 82);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(321, 30);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(52, 133);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(170, 128);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(279, 30);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(52, 200);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(122, 25);
            this.DateOfBirthLabel.TabIndex = 5;
            this.DateOfBirthLabel.Text = "Date of birth:";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthPicker.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.DateOfBirthPicker.CalendarTitleBackColor = System.Drawing.Color.Azure;
            this.DateOfBirthPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthPicker.Location = new System.Drawing.Point(180, 195);
            this.DateOfBirthPicker.MaxDate = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            this.DateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(269, 30);
            this.DateOfBirthPicker.TabIndex = 6;
            this.DateOfBirthPicker.Value = new System.DateTime(2019, 1, 5, 0, 0, 0, 0);
            // 
            // OibLabel
            // 
            this.OibLabel.AutoSize = true;
            this.OibLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OibLabel.Location = new System.Drawing.Point(52, 261);
            this.OibLabel.Name = "OibLabel";
            this.OibLabel.Size = new System.Drawing.Size(52, 25);
            this.OibLabel.TabIndex = 7;
            this.OibLabel.Text = "OIB:";
            // 
            // OibTextBox
            // 
            this.OibTextBox.BackColor = System.Drawing.Color.Azure;
            this.OibTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OibTextBox.Location = new System.Drawing.Point(110, 256);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(339, 30);
            this.OibTextBox.TabIndex = 8;
            this.OibTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OibTextBox_KeyPress);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(52, 321);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(87, 25);
            this.PositionLabel.TabIndex = 9;
            this.PositionLabel.Text = "Position:";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(180, 381);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(158, 52);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MintCream;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(544, 381);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(158, 52);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.BackColor = System.Drawing.Color.LightCyan;
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(483, 113);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(371, 229);
            this.ProjectListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose projects for employee";
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.BackColor = System.Drawing.Color.Azure;
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(145, 313);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PositionComboBox.Size = new System.Drawing.Size(304, 33);
            this.PositionComboBox.TabIndex = 15;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.OibLabel);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddEmployeeLabel);
            this.Name = "EditEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label OibLabel;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckedListBox ProjectListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PositionComboBox;
    }
}
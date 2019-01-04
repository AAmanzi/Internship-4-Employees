namespace Employees.Presentation
{
    partial class AddHoursForm
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
            this.AddHoursLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddHoursLabel
            // 
            this.AddHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHoursLabel.Location = new System.Drawing.Point(83, 26);
            this.AddHoursLabel.Name = "AddHoursLabel";
            this.AddHoursLabel.Size = new System.Drawing.Size(256, 31);
            this.AddHoursLabel.TabIndex = 0;
            this.AddHoursLabel.Text = "Add hours";
            this.AddHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(47, 67);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(335, 31);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursTextBox.Location = new System.Drawing.Point(197, 137);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(185, 38);
            this.HoursTextBox.TabIndex = 3;
            this.HoursTextBox.Text = "0";
            this.HoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursToAdd_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.Location = new System.Drawing.Point(138, 222);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(158, 52);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 314);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HoursTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddHoursLabel);
            this.Name = "AddHoursForm";
            this.Text = "AddHoursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddHoursLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}
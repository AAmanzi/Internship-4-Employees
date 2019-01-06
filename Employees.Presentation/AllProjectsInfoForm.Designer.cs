namespace Employees.Presentation
{
    partial class AllProjectsInfoForm
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
            this.ProjectListBox = new System.Windows.Forms.CheckedListBox();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.BackColor = System.Drawing.Color.LightCyan;
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(47, 68);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(416, 334);
            this.ProjectListBox.TabIndex = 1;
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.BackColor = System.Drawing.Color.MintCream;
            this.ViewDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetailsButton.Location = new System.Drawing.Point(516, 68);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(227, 153);
            this.ViewDetailsButton.TabIndex = 3;
            this.ViewDetailsButton.Text = "View details";
            this.ViewDetailsButton.UseMnemonic = false;
            this.ViewDetailsButton.UseVisualStyleBackColor = false;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(640, 350);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 52);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.BackColor = System.Drawing.Color.MintCream;
            this.ManageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.Location = new System.Drawing.Point(640, 262);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(103, 52);
            this.ManageButton.TabIndex = 8;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = false;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // AllProjectsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.ManageButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ViewDetailsButton);
            this.Controls.Add(this.ProjectListBox);
            this.Name = "AllProjectsInfoForm";
            this.Text = "AllProjectsInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProjectListBox;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ManageButton;
    }
}
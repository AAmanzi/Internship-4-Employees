namespace Employees.Presentation
{
    partial class ManageProjectsForm
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
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(40, 28);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(416, 334);
            this.ProjectListBox.TabIndex = 0;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(561, 28);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(227, 52);
            this.AddProjectButton.TabIndex = 2;
            this.AddProjectButton.Text = "Add new project";
            this.AddProjectButton.UseMnemonic = false;
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.Location = new System.Drawing.Point(561, 110);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(227, 52);
            this.EditProjectButton.TabIndex = 3;
            this.EditProjectButton.Text = "Edit selected";
            this.EditProjectButton.UseVisualStyleBackColor = true;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(561, 195);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(227, 52);
            this.DeleteProjectButton.TabIndex = 4;
            this.DeleteProjectButton.Text = "Delete selected";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(685, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManageProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.EditProjectButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.ProjectListBox);
            this.Name = "ManageProjectsForm";
            this.Text = "ManageProjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProjectListBox;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.Button button1;
    }
}
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.BackColor = System.Drawing.Color.LightCyan;
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(40, 28);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(416, 334);
            this.ProjectListBox.TabIndex = 0;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.BackColor = System.Drawing.Color.MintCream;
            this.AddProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectButton.Location = new System.Drawing.Point(561, 28);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(227, 52);
            this.AddProjectButton.TabIndex = 2;
            this.AddProjectButton.Text = "Add new project";
            this.AddProjectButton.UseMnemonic = false;
            this.AddProjectButton.UseVisualStyleBackColor = false;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.BackColor = System.Drawing.Color.MintCream;
            this.EditProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProjectButton.Location = new System.Drawing.Point(561, 110);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(227, 52);
            this.EditProjectButton.TabIndex = 3;
            this.EditProjectButton.Text = "Edit selected";
            this.EditProjectButton.UseVisualStyleBackColor = false;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProjectButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProjectButton.Location = new System.Drawing.Point(561, 195);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(227, 52);
            this.DeleteProjectButton.TabIndex = 4;
            this.DeleteProjectButton.Text = "Delete selected";
            this.DeleteProjectButton.UseVisualStyleBackColor = false;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(685, 310);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 52);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ManageProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.CloseButton);
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
        private System.Windows.Forms.Button CloseButton;
    }
}
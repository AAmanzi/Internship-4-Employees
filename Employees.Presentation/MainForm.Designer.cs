﻿namespace Employees.Presentation
{
    partial class MainForm
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
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.ManageProjectsButton = new System.Windows.Forms.Button();
            this.ViewEmployeesButton = new System.Windows.Forms.Button();
            this.ViewProjectsInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageEmployeesButton
            // 
            this.ManageEmployeesButton.BackColor = System.Drawing.Color.MintCream;
            this.ManageEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeesButton.Location = new System.Drawing.Point(12, 12);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(269, 101);
            this.ManageEmployeesButton.TabIndex = 0;
            this.ManageEmployeesButton.Text = "Manage Employees";
            this.ManageEmployeesButton.UseVisualStyleBackColor = false;
            this.ManageEmployeesButton.Click += new System.EventHandler(this.ManageEmployeesButton_Click);
            // 
            // ManageProjectsButton
            // 
            this.ManageProjectsButton.BackColor = System.Drawing.Color.MintCream;
            this.ManageProjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProjectsButton.Location = new System.Drawing.Point(336, 12);
            this.ManageProjectsButton.Name = "ManageProjectsButton";
            this.ManageProjectsButton.Size = new System.Drawing.Size(269, 101);
            this.ManageProjectsButton.TabIndex = 1;
            this.ManageProjectsButton.Text = "Manage Projects";
            this.ManageProjectsButton.UseVisualStyleBackColor = false;
            this.ManageProjectsButton.Click += new System.EventHandler(this.ManageProjectsButton_Click);
            // 
            // ViewEmployeesButton
            // 
            this.ViewEmployeesButton.BackColor = System.Drawing.Color.MintCream;
            this.ViewEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployeesButton.Location = new System.Drawing.Point(12, 145);
            this.ViewEmployeesButton.Name = "ViewEmployeesButton";
            this.ViewEmployeesButton.Size = new System.Drawing.Size(269, 101);
            this.ViewEmployeesButton.TabIndex = 2;
            this.ViewEmployeesButton.Text = "View Employee Info";
            this.ViewEmployeesButton.UseVisualStyleBackColor = false;
            this.ViewEmployeesButton.Click += new System.EventHandler(this.ViewEmployeesButton_Click);
            // 
            // ViewProjectsInfo
            // 
            this.ViewProjectsInfo.BackColor = System.Drawing.Color.MintCream;
            this.ViewProjectsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProjectsInfo.Location = new System.Drawing.Point(336, 145);
            this.ViewProjectsInfo.Name = "ViewProjectsInfo";
            this.ViewProjectsInfo.Size = new System.Drawing.Size(269, 101);
            this.ViewProjectsInfo.TabIndex = 3;
            this.ViewProjectsInfo.Text = "View Projects Info";
            this.ViewProjectsInfo.UseVisualStyleBackColor = false;
            this.ViewProjectsInfo.Click += new System.EventHandler(this.ViewProjectsInfoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(617, 258);
            this.Controls.Add(this.ViewProjectsInfo);
            this.Controls.Add(this.ViewEmployeesButton);
            this.Controls.Add(this.ManageProjectsButton);
            this.Controls.Add(this.ManageEmployeesButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageEmployeesButton;
        private System.Windows.Forms.Button ManageProjectsButton;
        private System.Windows.Forms.Button ViewEmployeesButton;
        private System.Windows.Forms.Button ViewProjectsInfo;
    }
}


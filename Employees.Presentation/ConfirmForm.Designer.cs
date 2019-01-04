﻿namespace Employees.Presentation
{
    partial class ConfirmForm
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
            this.ConfirmYesButton = new System.Windows.Forms.Button();
            this.ConfirmNoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConfirmYesButton
            // 
            this.ConfirmYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmYesButton.Location = new System.Drawing.Point(12, 101);
            this.ConfirmYesButton.Name = "ConfirmYesButton";
            this.ConfirmYesButton.Size = new System.Drawing.Size(161, 62);
            this.ConfirmYesButton.TabIndex = 1;
            this.ConfirmYesButton.Text = "Yes";
            this.ConfirmYesButton.UseVisualStyleBackColor = true;
            this.ConfirmYesButton.Click += new System.EventHandler(this.ConfirmYesButton_Click);
            // 
            // ConfirmNoButton
            // 
            this.ConfirmNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNoButton.Location = new System.Drawing.Point(225, 101);
            this.ConfirmNoButton.Name = "ConfirmNoButton";
            this.ConfirmNoButton.Size = new System.Drawing.Size(159, 62);
            this.ConfirmNoButton.TabIndex = 2;
            this.ConfirmNoButton.Text = "No";
            this.ConfirmNoButton.UseVisualStyleBackColor = true;
            this.ConfirmNoButton.Click += new System.EventHandler(this.ConfirmNoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Are you sure?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 204);
            this.Controls.Add(this.ConfirmNoButton);
            this.Controls.Add(this.ConfirmYesButton);
            this.Controls.Add(this.textBox1);
            this.Name = "ConfirmForm";
            this.Text = "ConfirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmYesButton;
        private System.Windows.Forms.Button ConfirmNoButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
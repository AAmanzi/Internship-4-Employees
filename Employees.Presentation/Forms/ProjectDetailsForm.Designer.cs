namespace Employees.Presentation.Forms
{
    partial class ProjectDetailsForm
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
            this.ProjectDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProjectDetailsTextBox
            // 
            this.ProjectDetailsTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ProjectDetailsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsTextBox.Location = new System.Drawing.Point(4, 4);
            this.ProjectDetailsTextBox.Name = "ProjectDetailsTextBox";
            this.ProjectDetailsTextBox.Size = new System.Drawing.Size(796, 447);
            this.ProjectDetailsTextBox.TabIndex = 0;
            this.ProjectDetailsTextBox.Text = "";
            // 
            // ProjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectDetailsTextBox);
            this.Name = "ProjectDetailsForm";
            this.Text = "ProjectDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProjectDetailsTextBox;
    }
}
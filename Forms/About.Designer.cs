
namespace Memento_App
{
    partial class FormAbout
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
            this.lblProgramAbout = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblMemento = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProgramAbout
            // 
            this.lblProgramAbout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramAbout.ForeColor = System.Drawing.Color.White;
            this.lblProgramAbout.Location = new System.Drawing.Point(12, 116);
            this.lblProgramAbout.Name = "lblProgramAbout";
            this.lblProgramAbout.Size = new System.Drawing.Size(552, 62);
            this.lblProgramAbout.TabIndex = 12;
            this.lblProgramAbout.Text = "This program is distributed in the hope that it will be useful for public use, bu" +
    "t WITHOUT ANY WARRANTY.";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 80);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(148, 24);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version nr. 0.0.1";
            // 
            // lblMemento
            // 
            this.lblMemento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemento.ForeColor = System.Drawing.Color.White;
            this.lblMemento.Location = new System.Drawing.Point(12, 9);
            this.lblMemento.Name = "lblMemento";
            this.lblMemento.Size = new System.Drawing.Size(93, 24);
            this.lblMemento.TabIndex = 9;
            this.lblMemento.Text = "Memento";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(12, 46);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(174, 24);
            this.lblCopyright.TabIndex = 13;
            this.lblCopyright.Text = "Created by Ars3nic";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProgramAbout);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblMemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProgramAbout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblMemento;
        private System.Windows.Forms.Label lblCopyright;
    }
}
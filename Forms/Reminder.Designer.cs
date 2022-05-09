
namespace Memento_App
{
    partial class Reminder
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
            this.lblSetDateTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnReminder = new FontAwesome.Sharp.IconButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSetDateTime
            // 
            this.lblSetDateTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDateTime.ForeColor = System.Drawing.Color.White;
            this.lblSetDateTime.Location = new System.Drawing.Point(7, 9);
            this.lblSetDateTime.Name = "lblSetDateTime";
            this.lblSetDateTime.Size = new System.Drawing.Size(180, 28);
            this.lblSetDateTime.TabIndex = 0;
            this.lblSetDateTime.Text = "Set Date and Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(12, 71);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 1;
            // 
            // btnReminder
            // 
            this.btnReminder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReminder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminder.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnReminder.IconColor = System.Drawing.Color.Black;
            this.btnReminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReminder.IconSize = 30;
            this.btnReminder.Location = new System.Drawing.Point(120, 108);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(146, 42);
            this.btnReminder.TabIndex = 8;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReminder.UseVisualStyleBackColor = false;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(12, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(442, 192);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblSetDateTime);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSetDateTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private FontAwesome.Sharp.IconButton btnReminder;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
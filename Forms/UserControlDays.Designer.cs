
namespace Memento_App
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDays = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbevent = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnReminder = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(10, 7);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(32, 25);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbevent
            // 
            this.lbevent.AutoSize = true;
            this.lbevent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbevent.Location = new System.Drawing.Point(42, 32);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(0, 21);
            this.lbevent.TabIndex = 1;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(42, 66);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 20);
            this.lbltime.TabIndex = 2;
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReminder
            // 
            this.btnReminder.BackColor = System.Drawing.Color.Transparent;
            this.btnReminder.FlatAppearance.BorderSize = 0;
            this.btnReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReminder.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnReminder.IconColor = System.Drawing.Color.White;
            this.btnReminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReminder.IconSize = 30;
            this.btnReminder.Location = new System.Drawing.Point(92, 3);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(50, 33);
            this.btnReminder.TabIndex = 3;
            this.btnReminder.UseVisualStyleBackColor = false;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(141, 86);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private FontAwesome.Sharp.IconButton btnReminder;
        public System.Windows.Forms.Label lbevent;
    }
}


namespace Memento_App
{
    partial class AdminTask
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
            this.lblUpdateTask = new System.Windows.Forms.Label();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtFinishTask = new System.Windows.Forms.TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblDeleteTask = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnUpdateTask = new FontAwesome.Sharp.IconButton();
            this.btnDeleteTask = new FontAwesome.Sharp.IconButton();
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            this.cboSeverity = new System.Windows.Forms.ComboBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateTask
            // 
            this.lblUpdateTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTask.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTask.Location = new System.Drawing.Point(700, 205);
            this.lblUpdateTask.Name = "lblUpdateTask";
            this.lblUpdateTask.Size = new System.Drawing.Size(105, 23);
            this.lblUpdateTask.TabIndex = 36;
            this.lblUpdateTask.Text = "Update Task";
            // 
            // lblAddTask
            // 
            this.lblAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.ForeColor = System.Drawing.Color.White;
            this.lblAddTask.Location = new System.Drawing.Point(605, 205);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(80, 23);
            this.lblAddTask.TabIndex = 35;
            this.lblAddTask.Text = "Add Task";
            // 
            // lblFinish
            // 
            this.lblFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(397, 31);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(131, 23);
            this.lblFinish.TabIndex = 34;
            this.lblFinish.Text = "Finish Task:";
            // 
            // txtFinishTask
            // 
            this.txtFinishTask.Location = new System.Drawing.Point(401, 62);
            this.txtFinishTask.Multiline = true;
            this.txtFinishTask.Name = "txtFinishTask";
            this.txtFinishTask.Size = new System.Drawing.Size(171, 23);
            this.txtFinishTask.TabIndex = 33;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(96, 110);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(131, 23);
            this.lblTaskDescription.TabIndex = 30;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // lblDeleteTask
            // 
            this.lblDeleteTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTask.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTask.Location = new System.Drawing.Point(806, 206);
            this.lblDeleteTask.Name = "lblDeleteTask";
            this.lblDeleteTask.Size = new System.Drawing.Size(89, 23);
            this.lblDeleteTask.TabIndex = 29;
            this.lblDeleteTask.Text = "Delete Task";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 290);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTaskName
            // 
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(96, 32);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(131, 27);
            this.lblTaskName.TabIndex = 25;
            this.lblTaskName.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(100, 62);
            this.txtTaskName.Multiline = true;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(171, 23);
            this.txtTaskName.TabIndex = 24;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.White;
            this.btnUpdateTask.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdateTask.IconColor = System.Drawing.Color.Black;
            this.btnUpdateTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateTask.IconSize = 40;
            this.btnUpdateTask.Location = new System.Drawing.Point(704, 242);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(85, 40);
            this.btnUpdateTask.TabIndex = 40;
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.White;
            this.btnDeleteTask.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteTask.IconColor = System.Drawing.Color.Black;
            this.btnDeleteTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteTask.IconSize = 40;
            this.btnDeleteTask.Location = new System.Drawing.Point(810, 242);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteTask.TabIndex = 38;
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.White;
            this.btnAddTask.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddTask.IconColor = System.Drawing.Color.Black;
            this.btnAddTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTask.IconSize = 40;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTask.Location = new System.Drawing.Point(600, 242);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(85, 40);
            this.btnAddTask.TabIndex = 37;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cboSeverity
            // 
            this.cboSeverity.FormattingEnabled = true;
            this.cboSeverity.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "Urgent"});
            this.cboSeverity.Location = new System.Drawing.Point(401, 146);
            this.cboSeverity.Name = "cboSeverity";
            this.cboSeverity.Size = new System.Drawing.Size(175, 21);
            this.cboSeverity.TabIndex = 42;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(100, 146);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(171, 23);
            this.txtTaskDescription.TabIndex = 43;
            // 
            // lblSeverity
            // 
            this.lblSeverity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeverity.ForeColor = System.Drawing.Color.White;
            this.lblSeverity.Location = new System.Drawing.Point(397, 110);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(131, 23);
            this.lblSeverity.TabIndex = 44;
            this.lblSeverity.Text = "Task level:";
            // 
            // AdminTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(980, 614);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.cboSeverity);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblUpdateTask);
            this.Controls.Add(this.lblAddTask);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.txtFinishTask);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblDeleteTask);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskName);
            this.Name = "AdminTask";
            this.Text = "AdminTask";
            this.Load += new System.EventHandler(this.AdminTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnUpdateTask;
        private FontAwesome.Sharp.IconButton btnDeleteTask;
        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.Label lblUpdateTask;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtFinishTask;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblDeleteTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cboSeverity;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblSeverity;
    }
}
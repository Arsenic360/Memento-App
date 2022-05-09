
namespace Memento_App
{
    partial class EmployeeTask
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
            this.cboTaskType = new System.Windows.Forms.ComboBox();
            this.lblUpdateTask = new System.Windows.Forms.Label();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblDeleteTask = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnUpdateTask = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnDeleteTask = new FontAwesome.Sharp.IconButton();
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTaskType
            // 
            this.cboTaskType.FormattingEnabled = true;
            this.cboTaskType.Items.AddRange(new object[] {
            "Personal",
            "Work"});
            this.cboTaskType.Location = new System.Drawing.Point(89, 223);
            this.cboTaskType.Name = "cboTaskType";
            this.cboTaskType.Size = new System.Drawing.Size(121, 21);
            this.cboTaskType.TabIndex = 42;
            // 
            // lblUpdateTask
            // 
            this.lblUpdateTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTask.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTask.Location = new System.Drawing.Point(686, 39);
            this.lblUpdateTask.Name = "lblUpdateTask";
            this.lblUpdateTask.Size = new System.Drawing.Size(105, 23);
            this.lblUpdateTask.TabIndex = 36;
            this.lblUpdateTask.Text = "Update Task";
            // 
            // lblAddTask
            // 
            this.lblAddTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.ForeColor = System.Drawing.Color.White;
            this.lblAddTask.Location = new System.Drawing.Point(570, 39);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(80, 23);
            this.lblAddTask.TabIndex = 35;
            this.lblAddTask.Text = "Add Task";
            // 
            // lblTaskType
            // 
            this.lblTaskType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskType.ForeColor = System.Drawing.Color.White;
            this.lblTaskType.Location = new System.Drawing.Point(85, 185);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(131, 23);
            this.lblTaskType.TabIndex = 34;
            this.lblTaskType.Text = "Task Type:";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(89, 140);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(171, 23);
            this.txtTaskDescription.TabIndex = 33;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishDate.ForeColor = System.Drawing.Color.White;
            this.lblFinishDate.Location = new System.Drawing.Point(314, 99);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(100, 23);
            this.lblFinishDate.TabIndex = 32;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(314, 39);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(111, 23);
            this.lblStartDate.TabIndex = 31;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(85, 99);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(131, 23);
            this.lblTaskDescription.TabIndex = 30;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // lblDeleteTask
            // 
            this.lblDeleteTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTask.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTask.Location = new System.Drawing.Point(810, 39);
            this.lblDeleteTask.Name = "lblDeleteTask";
            this.lblDeleteTask.Size = new System.Drawing.Size(89, 23);
            this.lblDeleteTask.TabIndex = 29;
            this.lblDeleteTask.Text = "Delete Task";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(318, 125);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 317);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTaskName
            // 
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(91, 29);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(131, 27);
            this.lblTaskName.TabIndex = 25;
            this.lblTaskName.Text = "Task Name:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(89, 62);
            this.txtTaskName.Multiline = true;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(171, 23);
            this.txtTaskName.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 40;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.Location = new System.Drawing.Point(689, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 40);
            this.btnBack.TabIndex = 41;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.White;
            this.btnUpdateTask.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdateTask.IconColor = System.Drawing.Color.Black;
            this.btnUpdateTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateTask.IconSize = 40;
            this.btnUpdateTask.Location = new System.Drawing.Point(690, 68);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(85, 40);
            this.btnUpdateTask.TabIndex = 40;
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdmin.IconColor = System.Drawing.Color.Black;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.Location = new System.Drawing.Point(780, 215);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(119, 64);
            this.btnAdmin.TabIndex = 39;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.White;
            this.btnDeleteTask.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteTask.IconColor = System.Drawing.Color.Black;
            this.btnDeleteTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteTask.IconSize = 40;
            this.btnDeleteTask.Location = new System.Drawing.Point(814, 68);
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
            this.btnAddTask.Location = new System.Drawing.Point(565, 68);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(85, 40);
            this.btnAddTask.TabIndex = 37;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // EmployeeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1015, 625);
            this.Controls.Add(this.cboTaskType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblUpdateTask);
            this.Controls.Add(this.lblAddTask);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblFinishDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblDeleteTask);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskName);
            this.Name = "EmployeeTask";
            this.Text = "EmployeeTask";
            this.Load += new System.EventHandler(this.EmployeeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTaskType;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnUpdateTask;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnDeleteTask;
        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.Label lblUpdateTask;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblDeleteTask;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskName;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento_App
{
    public partial class EmployeeTask : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        int Id = 0;
        CreateTask task1 = new CreateTask();

        public EmployeeTask()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            dataGridView1.DataSource = task1.GetAll();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text == "" || cboTaskType.SelectedIndex == -1)
            {
                MessageBox.Show("Completati toate campurile");
            }
            else
            {
                try
                {
                    UserTask user = new UserTask()
                    {
                        DenTask = txtTaskName.Text,
                        TipTask = cboTaskType.SelectedItem.ToString(),
                        DataStart = dateTimePicker1.Value,
                        DataStop = dateTimePicker2.Value,
                        DescTask = txtTaskDescription.Text,
                    };
                    task1.Insert(user);
                    txtTaskName.Text = "";
                    cboTaskType.SelectedItem = "";
                    dateTimePicker1.Value = dateTimePicker1.Value.Date;
                    dateTimePicker2.Value = dateTimePicker2.Value.Date;
                    txtTaskDescription.Text = "";
                    DisplayData();
                    Reset();
                    MessageBox.Show("Inregistrarea a fost inserata cu succes.");
                    conn.Close();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            cboTaskType.SelectedIndex = -1;
            txtTaskName.Text = "";
            txtTaskDescription.Text = "";
            Id = 0;
        }

        private void EmployeeTask_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                UserTask user = new UserTask()
                {
                    Id = Id,
                    DenTask = txtTaskName.Text,
                    TipTask = cboTaskType.SelectedItem.ToString(),
                    DataStart = dateTimePicker1.Value,
                    DataStop = dateTimePicker2.Value,
                    DescTask = txtTaskDescription.Text,
                };

                task1.Update(user);
                dateTimePicker2.Value = dateTimePicker2.Value.Date;
                DisplayData();
                Reset();
                MessageBox.Show("Inregistrarea a fost modificata cu succes.");
                conn.Close();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            TaskAD taskAdmin = new TaskAD();
            dataGridView1.DataSource = taskAdmin.GetAllAD();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                UserTask user = new UserTask()
                {
                    Id = Id,
                    DenTask = txtTaskName.Text,
                    TipTask = cboTaskType.SelectedItem.ToString(),
                    DataStart = dateTimePicker1.Value,
                    DataStop = dateTimePicker2.Value,
                    DescTask = txtTaskDescription.Text,
                };

                task1.Delete(user);
                txtTaskName.Text = "";
                cboTaskType.SelectedItem = "";
                dateTimePicker1.Value = dateTimePicker1.Value.Date;
                dateTimePicker2.Value = dateTimePicker2.Value.Date;
                txtTaskDescription.Text = "";
                DisplayData();
                Reset();
                MessageBox.Show("Inregistrarea a fost stearsa cu succes.");
                conn.Close();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTaskName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboTaskType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtTaskDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            CreateTask task = new CreateTask();
            dataGridView1.DataSource = task.GetAll();
        }
    }
}

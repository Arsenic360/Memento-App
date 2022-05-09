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
    public partial class AdminTask : Form
    {
        int Id = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        TaskAD task1 = new TaskAD();
        public AdminTask()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            dataGridView1.DataSource = task1.GetAllAD();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {

            if (txtTaskName.Text == "" || cboSeverity.SelectedIndex == -1)
            {
                MessageBox.Show("Completati toate campurile");
            }
            else
            {
                try
                {
                    Admin admin = new Admin()
                    {
                        DenTaskAd = txtTaskName.Text,
                        DescTaskAd = txtTaskDescription.Text,
                        NrZile = txtFinishTask.Text,
                        SevTaskAd = cboSeverity.Text,
                    };

                    task1.Insert(admin);
                    txtTaskName.Text = "";
                    txtTaskDescription.Text = "";
                    txtFinishTask.Text = "";
                    cboSeverity.Text = "";
                    con.Close();
                    DisplayData();
                    Reset();
                    MessageBox.Show("Inregistrarea a fost inserata cu succes.");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            txtTaskName.Text = "";
            txtTaskDescription.Text = "";
            txtFinishTask.Text = "";
            Id = 0;
        }

        private void AdminTask_Load(object sender, EventArgs e)
        {

            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtTaskName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTaskDescription.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtFinishTask.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboSeverity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        { 
                try
                {
                    Admin admin = new Admin()
                    {
                        DenTaskAd = txtTaskName.Text,
                        DescTaskAd = txtTaskDescription.Text,
                        NrZile = txtFinishTask.Text,
                        SevTaskAd = cboSeverity.Text,
                    };

                    task1.Delete(admin);
                    txtTaskName.Text = "";
                    txtTaskDescription.Text = "";
                    txtFinishTask.Text = "";
                    cboSeverity.Text = "";
                    con.Close();
                    DisplayData();
                    Reset();
                    MessageBox.Show("Inregistrarea a fost stearsa cu succes.");

                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
         }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin()
                {
                    DenTaskAd = txtTaskName.Text,
                    DescTaskAd = txtTaskDescription.Text,
                    NrZile = txtFinishTask.Text,
                    SevTaskAd = cboSeverity.Text,
                };

                task1.Update(admin);
                txtFinishTask.Text = "";
                con.Close();
                DisplayData();
                Reset();
                MessageBox.Show("Inregistrarea a fost modificata cu succes.");

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}


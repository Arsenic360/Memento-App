using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Memento_App
{
    public partial class FormUpdateEmployees : Form
    {
        
        public FormUpdateEmployees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        EmployeeRepository employeeRepository = new EmployeeRepository();
        private void Employees_Load(object sender, EventArgs e)
        {
            Display_Data();
            CountEvents();
        }
        public void Display_Data()
        {
            try
           {
                dataGridView1.DataSource = employeeRepository.GetAll();
            }
            catch (Exception exceptie)
           {
                MessageBox.Show(exceptie.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cboRole.SelectedItem.ToString(),
                };
                employeeRepository.Insert(employee);
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                Display_Data();
                

                MessageBox.Show("Record inserted successfully.");
             con.Close();
           }
           catch (Exception exceptie)
           {
               MessageBox.Show(exceptie.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cboRole.SelectedItem.ToString(),
                };
                employeeRepository.Delete(employee);
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                cboRole.SelectedItem = "";
                Display_Data();


                MessageBox.Show("Record deleted successfully.");
                con.Close();
            }
            catch (Exception exceptie)
            {
                MessageBox.Show(exceptie.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                 Employee employee = new Employee()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cboRole.SelectedItem.ToString(),
                };
                employeeRepository.Update(employee);
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                cboRole.SelectedItem = "";
                Display_Data();


                MessageBox.Show("Record update successfully.");
                con.Close();
            }
            catch (Exception exceptie)
            {
                MessageBox.Show(exceptie.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtId.Text= row.Cells[0].Value.ToString();
                txtFirstname.Text = row.Cells[1].Value.ToString();
                txtLastname.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtUsername.Text = row.Cells[4].Value.ToString();
                txtPassword.Text = row.Cells[5].Value.ToString();
                cboRole.SelectedItem = row.Cells[6].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            txtSearch.Visible = true;
            con.Open();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Login WHERE Username= '" + txtSearch.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adaptor.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception exceptie)
            {
                MessageBox.Show(exceptie.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Display_Data();
            btnCancel.Visible = false;
            txtSearch.Visible = false;
        }
        private void CountEvents()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblnumberUsers.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

    }
}

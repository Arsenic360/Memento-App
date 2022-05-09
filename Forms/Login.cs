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
using System.Threading;

namespace Memento_App
{
    public partial class FormLogin : Form
    {   
        //For draggable form
        bool mouseDown;
        private Point offset;
        private EventService eventService;
        public FormLogin(EventService eventService)
        {
            this.eventService = eventService;
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //Resizable form:
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM Login WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "' ", con);
                DataTable dt = new DataTable();
                String cmbItemValue = comboBox1.SelectedItem.ToString();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                       if (dt.Rows[i]["role"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are login as " + dt.Rows[0][0]);
                            if (comboBox1.SelectedIndex == 0)
                            {
                                FormAdmin home = new FormAdmin(dt.Rows[0][0].ToString(), username,eventService);
                                
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                FormInterfaceEmployee employee = new FormInterfaceEmployee(dt.Rows[0][0].ToString(),username,eventService);
                                employee.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            panel_register.BringToFront();
        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
             SqlCommand cmd;
             SqlDataReader dr;
             con.Open();
             if (txtFirstName.Text != string.Empty || txtLastName.Text != string.Empty ||txtEmail.Text !=string.Empty|| txtUserName.Text != string.Empty ||txtPassword.Text != string.Empty || txtConfirmPassword.Text !=string.Empty)
             {
                 if (txtPassword.Text == txtConfirmPassword.Text)
                 {
                     cmd = new SqlCommand("select * from Login where username='" + txtUserName.Text + "'", con);

                     dr = cmd.ExecuteReader();
                     if (dr.Read())
                     {
                         dr.Close();
                         MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         dr.Close();
                         cmd = new SqlCommand("insert into Login values(@Firstname,@Lastname,@Email,@Username,@Password,@Role)", con);
                         cmd.Parameters.AddWithValue("Firstname", txtFirstName.Text);
                         cmd.Parameters.AddWithValue("Lastname", txtLastName.Text);
                         cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                         cmd.Parameters.AddWithValue("Username", txtUserName.Text);
                         cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                         cmd.Parameters.AddWithValue("role", comboBox2.SelectedItem.ToString());
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Account created successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }

                 }
                 else
                 {
                     MessageBox.Show("Please enter same password in both password fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             con.Close();
             
        }

    

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFirstName.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
       
}

using FontAwesome.Sharp;
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
using Windows.System;

namespace Memento_App
{
    public partial class FormInterfaceEmployee : Form
    {
        //For sidebar menu movement
        bool sidebarExpand;

        //For draggable form
        bool mouseDown;
        private Point offset;

        //Fields
        public IconButton currentBtn;
        public Panel leftBorderBtn;
        public Form currentChildForm;
        public EventService eventService;

        public FormInterfaceEmployee(string role,string username,EventService eventService)
        {
            this.eventService = eventService;
            InitializeComponent();

            //Showing type of role after login
            label2.Text = role + " (" + username + ")"; ;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 83);
            sidebar.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void panelWindow_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panelWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panelWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 55, 60);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Home;
            iconCurrentForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnHome.Enabled == true)
            {
                currentChildForm.Close();
                Reset();
            }
            else
            {
                MessageBox.Show("You are already in Home section.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeTask());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAbout());
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin logare = new FormLogin(eventService);
            logare.Show(); 
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            //Set timer interval to lowest to make smoother. I set the interval to 1.
            SidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and Maximum size of sidebar Panel

            if (sidebarExpand)
            {
                //If sidebar is expand, minimize 
                sidebar.Width -= 30;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 30;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

    }
}

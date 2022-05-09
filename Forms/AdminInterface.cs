using FontAwesome.Sharp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento_App
{
    public partial class FormAdmin : Form
    {

        //For sidebar menu movement
        bool sidebarExpand;

        int month, year;

        //Create a static variable that we can pass to another form for month and year
        public static int static_month, static_year;

        //For calendar
        int PW;
        bool Hided;

        //For theme color
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        //For draggable form
        bool mouseDown;
        private Point offset;

        //Fields
       public IconButton currentBtn;
       public Panel leftBorderBtn;
       public Form currentChildForm;
       public EventService eventService;

        public FormAdmin(string role, string username, EventService eventService)
        {
            this.eventService = eventService;
            InitializeComponent();

            //Count all the events scheduled
            CountEvents();

            //For sliding calendar
            PW = Spanel.Width;
            Hided = false;
            Hided = true;
            Spanel.Width = 0;
            //--

            //Showing type of role after login
            lblStatus.Text = role + " ("+ username +")";
            //--

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

////////////////////////////////////////////////{   Resizable and Form movement
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
/////////////////////////////////////////////////////} 


//////////////////////////////////////////////////////////{ Windows Theme
       
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void LoadTheme() //This method is for changing theme color using Windows Color Settings
        {
            var themeColor = WindowsTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            panel3.BackColor = lightColor;
            sidebar.BackColor = lightColor;
            panel1.BackColor = lightColor;
            this.BackColor = lightColor;

        }
        private void btnChangeTheme_Click_1(object sender, EventArgs e)
        {
            btnDefaultTheme.Visible = true;
            Process.Start("ms-settings:colors");
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

        }
        private void btnDefaultTheme_Click_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            panel1.BackColor = Color.FromArgb(35, 40, 45 );
            this.BackColor = Color.FromArgb(35, 40, 45);
            btnDefaultTheme.Visible = false;
        }
///////////////////////////////////////////////////////////////////////////////}


///////////////////////////////////////////////////{ Buttons for Minimize, Maximize, Exit
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
//////////////////////////////////////////////////////}

//////////////////////////////////////////////////////{ Properties Buttons
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
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpdateEmployees());
        }

        private void btnHome_Click_1(object sender, EventArgs e)
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

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAbout());
        }
        private void btnTaskAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminTask());
        }

        //////////////////////////////////////////////////////}

        private void FormHome_Load(object sender, EventArgs e)
        {
            btnDefaultTheme.Visible = false;
            displayDays();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin logare = new FormLogin(eventService);
            logare.Show();
        }
       

////////////////////////////////////////{ Sliding Menu
        private void tmrSlidingCalendar_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                Spanel.Width = Spanel.Width + 40;
                if(Spanel.Width >= PW)
                {
                    tmrSlidingCalendar.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Width = Spanel.Width - 40;
                if(Spanel.Width <= 0)
                {
                    tmrSlidingCalendar.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET the Minimum and Maximum size of sidebar Panel

            if (sidebarExpand)
            {
                //If sidebar is expand, minimize 
                sidebar.Width -= 30;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 30;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Set timer interval to lowest to make smoother. I set the interval to 1.
            SidebarTimer.Start();
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tmrSlidingCalendar.Start();
        }
/////////////////////////////////////////}

/////////////////////////////////{ Buttons for next and previous month of calendar

        //Displaying Days
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            //Get first day of the month.

            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //Convert the startofthemonth to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //First lets create a blank usercontrol
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            //Create usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(eventService);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
 
            //Decrement month to go previous month
            month--;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
             lblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //Convert the startofthemonth to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1 ;

            //First lets create a blank usercontrol
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            //Create usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(eventService);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }

       

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            //Clear container
            dayContainer.Controls.Clear();
          
            //Increment month to go next month
            month++;
            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get count of days of the month
            int days = DateTime.DaysInMonth(year, month);

            //Convert the startofthemonth to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1;

            //Create a blank usercontrol
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }
            //Create usercontrol for days

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays(eventService);
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);
            }
        }
        private void CountEvents()
        {
            lblCountEvents.Text = eventService.CountEvents();
        }
/////////////////////////////////////////////////////////}
    }
}

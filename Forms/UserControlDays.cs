using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Memento_App
{
    public partial class UserControlDays : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True";
        public FormEvent form;

        private EventService eventService;

        //Create another static variable for day
        public static string static_day;
        public UserControlDays(EventService eventService)
        {
            this.eventService = eventService;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }
        public void days(int numday)
        {
            lblDays.Text = numday + " ";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            //start timer if user usercontroldays is click
            timer1.Start();
            FormEvent eventform = new FormEvent(eventService);
            eventform.Show();
        }

        //Create a new method to display event
        private void displayEvent()
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "SELECT * FROM Event WHERE date= @date";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", FormAdmin.static_year + "-" + FormAdmin.static_month + "-" + lblDays.Text + lbltime.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["Event"].ToString();
                lbltime.Text = reader["Time"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            con.Close();

        }

        //Create a timer for auto display event if new event is added
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Call the displayEvent method
            displayEvent();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder();
            reminder.Show();
        }
    }  
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Timers;

namespace Memento_App
{
    public partial class FormEvent : Form
    {
        static System.Timers.Timer timer;
        private EventService eventService;
        public FormEvent(EventService eventService)
        {
            this.eventService = eventService;
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            //Call the static variables I declare
            txtDate.Text = FormAdmin.static_month + "/" + UserControlDays.static_day + "/" + FormAdmin.static_year;
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            eventService.AddEvent(txtDate.Text, txtEvent.Text, dateTimePicker1.Value);
        }
     
    }
}

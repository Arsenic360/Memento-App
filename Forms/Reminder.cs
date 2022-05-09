using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Memento_App
{
    public partial class Reminder : Form
    {
        UserControlDays usr;
        static System.Timers.Timer timer;
        public Reminder()
        {
            InitializeComponent();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            schedule_Timer();
        }
        private void schedule_Timer()
        {
            DateTime nowTime = DateTime.Now;
            DateTime scheduledTime = dtpTime.Value;
            if (nowTime > scheduledTime)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }
            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new System.Timers.Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           
            PopupNotifier notif = new PopupNotifier();
            notif.TitleText = "New Notification from Memento";
            notif.TitleText = "Task: '" + usr.lbevent + "' + is reminded.";

            timer.Stop();
            schedule_Timer();
        }

    }
}

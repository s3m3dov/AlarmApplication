using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SoundPlayer sp;
        private void Main_Load(object sender, EventArgs e)
        {
            timer_currenttime.Start();
            tb_alarmtime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_currenttime_Tick(object sender, EventArgs e)
        {
            tb_currenttime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_setalarm_Click(object sender, EventArgs e)
        {
            timer_alarm.Start();
        }

        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            if (tb_currenttime.Text == tb_alarmtime.Text)
            {

                string soundPath = Application.StartupPath + "\\music\\alarm1.wav";
                //MessageBox.Show(soundPath);
                sp = new SoundPlayer(soundPath);
                sp.Play();
                timer_alarm.Stop();
                //MessageBox.Show("Alarm is on! Time to wake up!");
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            sp.Stop();
        }

        private void btn_snooze_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            sp.Stop();
            string old_alarm_time = tb_alarmtime.Text;
            MessageBox.Show(old_alarm_time);
        }
    }
}

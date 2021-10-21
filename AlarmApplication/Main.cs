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

        private void timer_currenttime_Tick(object sender, EventArgs e)
        {
            string current_time = DateTime.Now.ToLongTimeString();
            tb_currenttime.Text = current_time;
            Main.ActiveForm.Text = "Alarm " + DateTime.Now.ToLongTimeString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer_currenttime.Start();
            tb_alarmtime.Text = DateTime.Now.ToLongTimeString(); 
        }


        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            if (tb_currenttime.Text == tb_alarmtime.Text)
            {
                string sound_file_name = cb_alarmsound.Text.ToLower();
                string soundPath = Application.StartupPath + "\\music\\" + sound_file_name + ".wav";
                sp = new SoundPlayer(soundPath);
                sp.Play();
                timer_alarm.Stop();
            }

        }

        private void timer_snoozetime_Tick(object sender, EventArgs e)
        {
            tb_snoozetime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_setalarm_Click(object sender, EventArgs e)
        {
            timer_alarm.Start();
            Console.WriteLine("Set Alarm " + DateTime.Now);
            tb_console.AppendText("[ " + DateTime.Now.ToLongTimeString() + " ] Alarm is set!\r\n");
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            sp.Stop();
            Console.WriteLine("Stop " + DateTime.Now);
            tb_console.AppendText("[ " + DateTime.Now.ToLongTimeString() + " ] Alarm is stopped!\r\n");
        }

        private void btn_snooze_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            sp.Stop();
            // string old_alarm_time = tb_alarmtime.Text;
            string snooze_time = tb_snoozetime.Text;
            int snooze_time_int = Int32.Parse(snooze_time);
            string new_alarm_time = DateTime.Now.AddMinutes(snooze_time_int).ToLongTimeString();
            tb_alarmtime.Text = new_alarm_time;
            timer_alarm.Start();
            Console.WriteLine("Snooze " + DateTime.Now);
            tb_console.AppendText("[ " + DateTime.Now.ToLongTimeString() + " ] Alarm is snoozed!\r\n");
        }

    }
}

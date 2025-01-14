﻿
namespace AlarmApplication
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.tb_currenttime = new System.Windows.Forms.TextBox();
            this.timer_currenttime = new System.Windows.Forms.Timer(this.components);
            this.tb_alarmtime = new System.Windows.Forms.TextBox();
            this.lbl_alarmtime = new System.Windows.Forms.Label();
            this.btn_setalarm = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer_alarm = new System.Windows.Forms.Timer(this.components);
            this.btn_snooze = new System.Windows.Forms.Button();
            this.cb_alarmsound = new System.Windows.Forms.ComboBox();
            this.lbl_alarmsound = new System.Windows.Forms.Label();
            this.lbl_snoozetime = new System.Windows.Forms.Label();
            this.tb_snoozetime = new System.Windows.Forms.TextBox();
            this.tb_console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_currenttime
            // 
            this.lbl_currenttime.AutoSize = true;
            this.lbl_currenttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currenttime.Location = new System.Drawing.Point(571, 56);
            this.lbl_currenttime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_currenttime.Name = "lbl_currenttime";
            this.lbl_currenttime.Size = new System.Drawing.Size(117, 24);
            this.lbl_currenttime.TabIndex = 3;
            this.lbl_currenttime.Text = "Current time:";
            // 
            // tb_currenttime
            // 
            this.tb_currenttime.Enabled = false;
            this.tb_currenttime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_currenttime.Location = new System.Drawing.Point(700, 49);
            this.tb_currenttime.Margin = new System.Windows.Forms.Padding(6);
            this.tb_currenttime.Name = "tb_currenttime";
            this.tb_currenttime.ReadOnly = true;
            this.tb_currenttime.Size = new System.Drawing.Size(144, 31);
            this.tb_currenttime.TabIndex = 2;
            this.tb_currenttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_currenttime
            // 
            this.timer_currenttime.Interval = 900;
            this.timer_currenttime.Tick += new System.EventHandler(this.timer_currenttime_Tick);
            // 
            // tb_alarmtime
            // 
            this.tb_alarmtime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_alarmtime.Location = new System.Drawing.Point(700, 92);
            this.tb_alarmtime.Margin = new System.Windows.Forms.Padding(6);
            this.tb_alarmtime.Name = "tb_alarmtime";
            this.tb_alarmtime.Size = new System.Drawing.Size(144, 31);
            this.tb_alarmtime.TabIndex = 4;
            this.tb_alarmtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_alarmtime
            // 
            this.lbl_alarmtime.AutoSize = true;
            this.lbl_alarmtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alarmtime.Location = new System.Drawing.Point(584, 99);
            this.lbl_alarmtime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_alarmtime.Name = "lbl_alarmtime";
            this.lbl_alarmtime.Size = new System.Drawing.Size(104, 24);
            this.lbl_alarmtime.TabIndex = 5;
            this.lbl_alarmtime.Text = "Alarm time:";
            // 
            // btn_setalarm
            // 
            this.btn_setalarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setalarm.Location = new System.Drawing.Point(716, 374);
            this.btn_setalarm.Name = "btn_setalarm";
            this.btn_setalarm.Size = new System.Drawing.Size(128, 49);
            this.btn_setalarm.TabIndex = 6;
            this.btn_setalarm.Text = "Set Alarm";
            this.btn_setalarm.UseVisualStyleBackColor = true;
            this.btn_setalarm.Click += new System.EventHandler(this.btn_setalarm_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Location = new System.Drawing.Point(601, 374);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(87, 49);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer_alarm
            // 
            this.timer_alarm.Interval = 900;
            this.timer_alarm.Tick += new System.EventHandler(this.timer_alarm_Tick);
            // 
            // btn_snooze
            // 
            this.btn_snooze.Location = new System.Drawing.Point(733, 178);
            this.btn_snooze.Name = "btn_snooze";
            this.btn_snooze.Size = new System.Drawing.Size(111, 49);
            this.btn_snooze.TabIndex = 8;
            this.btn_snooze.Text = "Snooze";
            this.btn_snooze.UseVisualStyleBackColor = true;
            this.btn_snooze.Click += new System.EventHandler(this.btn_snooze_Click);
            // 
            // cb_alarmsound
            // 
            this.cb_alarmsound.FormattingEnabled = true;
            this.cb_alarmsound.Items.AddRange(new object[] {
            "Default",
            "Radar",
            "Morning"});
            this.cb_alarmsound.Location = new System.Drawing.Point(700, 132);
            this.cb_alarmsound.Name = "cb_alarmsound";
            this.cb_alarmsound.Size = new System.Drawing.Size(144, 32);
            this.cb_alarmsound.TabIndex = 9;
            // 
            // lbl_alarmsound
            // 
            this.lbl_alarmsound.AutoSize = true;
            this.lbl_alarmsound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alarmsound.Location = new System.Drawing.Point(566, 140);
            this.lbl_alarmsound.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_alarmsound.Name = "lbl_alarmsound";
            this.lbl_alarmsound.Size = new System.Drawing.Size(122, 24);
            this.lbl_alarmsound.TabIndex = 10;
            this.lbl_alarmsound.Text = "Alarm sound:";
            // 
            // lbl_snoozetime
            // 
            this.lbl_snoozetime.AutoSize = true;
            this.lbl_snoozetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snoozetime.Location = new System.Drawing.Point(497, 190);
            this.lbl_snoozetime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_snoozetime.Name = "lbl_snoozetime";
            this.lbl_snoozetime.Size = new System.Drawing.Size(151, 24);
            this.lbl_snoozetime.TabIndex = 12;
            this.lbl_snoozetime.Text = "Snooze minutes:";
            // 
            // tb_snoozetime
            // 
            this.tb_snoozetime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_snoozetime.Location = new System.Drawing.Point(660, 188);
            this.tb_snoozetime.Margin = new System.Windows.Forms.Padding(6);
            this.tb_snoozetime.Name = "tb_snoozetime";
            this.tb_snoozetime.Size = new System.Drawing.Size(57, 31);
            this.tb_snoozetime.TabIndex = 11;
            this.tb_snoozetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(12, 283);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.Size = new System.Drawing.Size(263, 256);
            this.tb_console.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::AlarmApplication.Properties.Resources.clock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 598);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.lbl_snoozetime);
            this.Controls.Add(this.tb_snoozetime);
            this.Controls.Add(this.lbl_alarmsound);
            this.Controls.Add(this.cb_alarmsound);
            this.Controls.Add(this.btn_snooze);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_setalarm);
            this.Controls.Add(this.lbl_alarmtime);
            this.Controls.Add(this.tb_alarmtime);
            this.Controls.Add(this.lbl_currenttime);
            this.Controls.Add(this.tb_currenttime);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_currenttime;
        private System.Windows.Forms.TextBox tb_currenttime;
        private System.Windows.Forms.Timer timer_currenttime;
        private System.Windows.Forms.TextBox tb_alarmtime;
        private System.Windows.Forms.Label lbl_alarmtime;
        private System.Windows.Forms.Button btn_setalarm;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer_alarm;
        private System.Windows.Forms.Button btn_snooze;
        private System.Windows.Forms.ComboBox cb_alarmsound;
        private System.Windows.Forms.Label lbl_alarmsound;
        private System.Windows.Forms.Label lbl_snoozetime;
        private System.Windows.Forms.TextBox tb_snoozetime;
        private System.Windows.Forms.TextBox tb_console;
    }
}


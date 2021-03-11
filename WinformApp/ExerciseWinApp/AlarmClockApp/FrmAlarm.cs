using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool isSetAlarm;
        WindowsMediaPlayer mediaPlayer;

        public FrmAlarm()
        {
            InitializeComponent();
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = ""; // 시작할 때 글자를 지워줌

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.ShowUpDown = true;
            DtpAlarmTime.Value = DateTime.Now;

            MyTimer.Interval = 1000; //1sec
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("hh:mm:ss");

            if (isSetAlarm == true) // 알람 설정이 되었다면
            {
                // 알람 시간하고 현재 시간 일치하면 알람 울림
                if (SetDay == DateTime.Today && SetTime.Hour == curDate.Hour && SetTime.Minute == curDate.Minute
                    && SetTime.Second == curDate.Second)
                {
                    //isSetAlarm = false; // 알람 설정 종료
                    BtnRelease_Click(sender, e);
                    mediaPlayer.URL = @".\medias\alarm.mp3";
                    mediaPlayer.controls.play();
                    MessageBox.Show("알람!!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} {SetTime.ToString("hh:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            isSetAlarm = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            isSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigitalClock;
        }
    }
}

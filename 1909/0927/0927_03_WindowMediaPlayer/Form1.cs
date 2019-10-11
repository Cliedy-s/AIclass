using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace _0927_03_WindowMediaPlayer
{
    public partial class Form1 : Form
    {
        DateTime alamDateTime;
        DateTime dDay;
        DateTime tTime;
        private bool setAlarm;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            tabControl1.SelectedIndex = 1;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            dtpTime.CustomFormat = "tt hh : mm";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.ShowUpDown = true; // 달력 x

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime cTIme = DateTime.Now;
            lblDate.Text = cTIme.ToShortDateString();
            lblTime.Text = cTIme.ToLongTimeString();

            if (setAlarm)
            {
                if (dDay == DateTime.Today && cTIme.Hour == tTime.Hour && cTIme.Minute == tTime.Minute)
                {
                    setAlarm = false;

                    //wav
                    //SoundPlayer sound = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav");
                    //sound.Play();

                    //mp3
                    WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();
                    myPlayer.URL = @"D:\AIclass\1909\0927\0927_03_WindowMediaPlayer\Music\preview.mp3";
                    myPlayer.controls.play();
                }
            }

        }

        private void BtnDateTimeSet_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(dtpDate.Text);
            tTime = DateTime.Parse(dtpTime.Text);

            setAlarm = true;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "Alarm : " + dDay.ToShortDateString() + " " + tTime.ToLongTimeString();

            tabControl1.SelectedTab = tabPage2;
        }

        private void BtnDateTimeUnset_Click(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            setAlarm = false;
            lblAlarm.ForeColor = Color.Black;
            lblAlarm.Text = "Alarm";
        }
    }
}

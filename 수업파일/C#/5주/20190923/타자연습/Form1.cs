using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TypeTutor
{
    public partial class Form1 : Form
    {
        List<string> Sentence= new List<string>();
        readonly byte ScoreAdd = 200;
        int CurrentSentenceIndex;
        int progressInterval = 1;
        int Score = 0;
        byte RemainingChance = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //파일을 읽는데 사용할 스트림리더 변수를 선언합니다.
            StreamReader sr = new StreamReader("typedata.txt", Encoding.Default);

            int i = 0;
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                Sentence.Add(str);
                Debug.WriteLine(str);
                i = i + 1;
            }

            //스트림리더 객체를 닫습니다.
            sr.Close();

            txtSentence.Text = "";
            txtSentence.Enabled = false;

            lblRemainingChance.Text = "";
            lblScore.Text = "";
            lblSentence.Text = "";
        }

        private void 시작ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Init();
            DisplaySentence();
        }

        private void Init()
        {
            progressBar1.Value = 100;
            Score = 0;
            RemainingChance = 10;
            txtSentence.Enabled = true;
            lblRemainingChance.Text = RemainingChance.ToString();
            lblScore.Text = Score.ToString();
            txtSentence.Focus();
        }

        private void DisplaySentence()
        {
            int i;
            Random ra = new Random();
            i = ra.Next(0, Sentence.Count);

            lblSentence.Text = Sentence[i];
            CurrentSentenceIndex = i;
            
            txtSentence.Clear();
            progressBar1.Value = 100;
        }

        private void TxtSentence_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= progressInterval;

            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                RemainingChance = Convert.ToByte((int)RemainingChance - 1);
                lblRemainingChance.Text = RemainingChance.ToString();
                if (RemainingChance == 0)
                {
                    txtSentence.Enabled = false;
                    MessageBox.Show("타자연습을 중지합니다.", "연습 종료");
                    return;
                }

                DisplaySentence();
            }
        }

        private void TxtSentence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                timer1.Stop();

                if (Sentence[CurrentSentenceIndex].Equals(txtSentence.Text.Trim()))
                {
                    Score = Score + ScoreAdd;
                    lblScore.Text = Score.ToString();
                }
                else
                {
                    RemainingChance = Convert.ToByte((int)RemainingChance - 1);
                    lblRemainingChance.Text = RemainingChance.ToString();

                    if (RemainingChance == 0)   
                    {
                        txtSentence.Enabled = false;
                        MessageBox.Show("타자연습을 중지합니다.", "연습 종료");
                        return;
                    }
                }

                DisplaySentence();
            }
        }
    }
}

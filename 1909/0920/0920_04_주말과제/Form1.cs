using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_04_주말과제
{
    public partial class Form1 : Form
    {
        int opportunity=0;
        int score=0;
        int internalStep;

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value > 0) progressBar.Value--;
            else if (progressBar.Value == 0) // 프로그래스바 0일때 
            {
                //기회 줄이고 처음처럼
                opportunity--;
                lblOpportunity.Text = opportunity.ToString();

                progressBar.Value = progressBar.Maximum;
                txtTypeBox.Clear();
                timer.Stop();
            }
        }

        private void startGame(object sender, EventArgs e)
        {
            // 난이도와 한/영에 따라 다른 처리
            StringBuilder sb = new StringBuilder(Environment.CurrentDirectory);

            timer.Interval = 100;
            switch((sender as ToolStripMenuItem).Text)
            {
                case "초급":
                    sb.Append(@"\TextsForGame01");
                    opportunity = 10;
                    internalStep = 10;
                    break;
                case "중급":
                    sb.Append(@"\TextsForGame02");
                    opportunity = 8;
                    internalStep = 12;
                    break;
                case "고급":
                    sb.Append(@"\TextsForGame03");
                    opportunity = 5;
                    internalStep = 14;
                    break;
            }
            if (chkENG.Checked) sb.Append("_ENG");
            else sb.Append("_KOR");

            sb.Append(".txt");
            chkENG.Enabled = false;

            // 정답 파일 가져오기
            string filePath = sb.ToString();
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    string str;
                    list.Clear();
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    while ((str = sr.ReadLine()) != null)
                        list.Add(str);
                    sr.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //

            // 게임 도중이였을때 멈춰주기
            progressBar.Value = progressBar.Maximum;
            timer.Stop();
            //

            // 시작 세팅
            score = 0;
            txtTypeBox.Enabled = true;
            Random rand = new Random();
            lblAnswer.Text = list[rand.Next(0, list.Count)];
            lblOpportunity.Text = opportunity.ToString();
            lblScore.Text = score.ToString();
            //
        }

        private void TxtTypeBox_TextChanged(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void TxtTypeBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터 누르면 
            if (e.KeyCode == Keys.Enter)
            {
                //if (txtTypeBox.Text.Equals(lblAnswer.Text)) // 정답 일 경우
                { // 점수를 100 증가시키고 프로그래스바가 줄어드는 속도를 빠르게 한다.
                    score += 100;
                    if(timer.Interval - internalStep > 0 ) timer.Interval -= internalStep;
                    Debug.WriteLine("Alambana_{0} : {1} - {2}", this.Text, timer.Interval, internalStep);
                }
                // else opportunity--; // 틀릴 경우

                lblScore.Text = score.ToString();
                lblOpportunity.Text = opportunity.ToString();

                progressBar.Value = progressBar.Maximum; // 프로그래스바 꽉차게
                txtTypeBox.Clear();
                timer.Stop();

                Random rand = new Random();
                lblAnswer.Text = list[rand.Next(0, list.Count)]; // 다시 정답을 가져온다

                if (opportunity < 1) // 기회가 없으면
                {
                    MessageBox.Show("타자연습을 중지합니다.");
                    txtTypeBox.Enabled = false;
                    chkENG.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Maximum;
        }
    }
}

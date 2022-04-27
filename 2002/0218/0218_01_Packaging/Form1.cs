﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0218_01_Packaging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckUpdate();

            Properties.Settings.Default.Upgrade();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment appDeployment = ApplicationDeployment.CurrentDeployment;
                lblVersion.Text = $"Version : {appDeployment.CurrentVersion.ToString()}";
            }
            else
            {
                lblVersion.Text = "Version : NotDeploy";
            }
        }

        private void CheckUpdate()
        { // 현재 컴퓨터와 서버와 비교후 업데이트 해야하는지 확인하는 메서드
            UpdateCheckInfo info = null;
            if(!ApplicationDeployment.IsNetworkDeployed)
            {
                MessageBox.Show("not deployed using Clickonce");
            }
            else
            {
                ApplicationDeployment appDep = ApplicationDeployment.CurrentDeployment;
                info = appDep.CheckForDetailedUpdate();
                if (info.UpdateAvailable)
                {
                    bool doupdate = true;
                    if (doupdate)
                    {
                        appDep.Update();
                        MessageBox.Show("프로그램이 업데이트 되어서 재시작합니다...");
                        this.Close();
                        Application.Restart();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두번째버튼 추가");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("배포 후 변경");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("강제업데이트");
        }
    }
}
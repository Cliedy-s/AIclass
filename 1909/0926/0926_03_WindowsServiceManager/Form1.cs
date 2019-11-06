 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace _0926_03_WindowsServiceManager
{
    public partial class Form1 : Form
    {
        ServiceController[] services;
        ServiceController myService = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnServiceStart.Enabled = false;
            btnServiceStop.Enabled = false;
        }
        private void SetTexts(ServiceController myService)
        {
            txtServiceName.Text = myService.ServiceName;
            txtServiceState.Text = myService.Status.ToString();
        }

        private void BtnServiceStart_Click(object sender, EventArgs e)
        {
            myService.Start();
            myService.WaitForStatus(ServiceControllerStatus.Running);
            StatusCheck();
        }
        private void BtnServiceStop_Click(object sender, EventArgs e)
        {
            myService.Stop();
            myService.WaitForStatus(ServiceControllerStatus.Stopped);
            StatusCheck();
        }

        private void StatusCheck()
        {
            if (myService != null)
            {
                switch (myService.Status)
                {
                    case ServiceControllerStatus.Stopped:
                        btnServiceStart.Enabled = true;
                        btnServiceStop.Enabled = false;
                        break;
                    case ServiceControllerStatus.Running:
                        btnServiceStart.Enabled = false;
                        btnServiceStop.Enabled = true;
                        break;
                    default:
                        break;
                }
                txtServiceState.Text = myService.Status.ToString();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            e.Cancel = true;
        }
        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        { // 프로그램 보이기
            this.Visible = true;

        }
        private void 중지ToolStripMenuItem_Click(object sender, EventArgs e)
        { //프로그램 종료
            this.notifyIcon1.Visible = false;
            // this.Close(); // => closed 실행
            Application.Exit(); // 왠지.. 안됨
            Environment.Exit(0); // 종료 ㅇ
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            bool bFlag = false;

            services = ServiceController.GetServices();

            foreach (var item in services)
            {
                if (item.DisplayName == "_092601WindowsService")
                {
                    MessageBox.Show(item.DisplayName);
                    bFlag = true;
                    myService = item;
                    SetTexts(item);
                    StatusCheck();
                    break;
                }
            }
            if (!bFlag)
            {
                txtServiceName.Text = "x";
                txtServiceState.Text = "x";
            }
        }
    }
}

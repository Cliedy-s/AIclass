using Print_Csharp;
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
using System.Deployment.Application;

namespace _1002_04_PrintDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckUpdate();

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
            if (!ApplicationDeployment.IsNetworkDeployed)
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

        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextPrintDocument textPrintDocument = new TextPrintDocument(new StringReader(textBox1.Text), textBox1.Font);
            printPreviewDialog1.Document = textPrintDocument;
            printPreviewDialog1.ShowDialog();
        }
    }
}

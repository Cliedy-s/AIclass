using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1210_SettingsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   // GetConfig
            txtUserID.Text = Properties.Settings.Default["UserID"].ToString();
            txtPwd.Text = Properties.Settings.Default["Pwd"].ToString();
            txtCommonData.Text = Properties.Settings.Default["CommonData"].ToString();

            string connectionString = Properties.Settings.Default["ConnectionString"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // SetConfig
            Properties.Settings.Default.UserID = txtUserID.Text;
            Properties.Settings.Default.Pwd = txtPwd.Text;
            Properties.Settings.Default.CommonData = txtCommonData.Text;

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 다른 파일들도 저장할 수 있는 경로 ( exe 경로에는 파일이 저장되지 않을 수 있음(권한이 없을 수 있음) )
            string projectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            string projectVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string configPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), projectName, projectVersion);
            string configPathAndName = System.IO.Path.Combine(configPath, projectName + ".config");

            //MessageBox.Show(configPathAndName);
        }
    }
}

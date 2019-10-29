using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1029_01_Regestry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Create Sub Key
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("MyGudi");
            key.Close();

            MessageBox.Show("레지스트리 키 생성");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Create Value
            RegistryKey key;
            float ver;

            key = Registry.CurrentUser.OpenSubKey(@"Software\MyGudi", true);
            key.SetValue("AppName", "MyRegTestApp");

            ver = Convert.ToSingle(key.GetValue("Version", 0.0));

            if (ver < 1.1)
                key.SetValue("Version", 1.1);

            key.Close();
            MessageBox.Show("AppName 과 Version 생성");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.DeleteSubKey("MyGudi", true);
            key.Close();
            MessageBox.Show("MyGudi 삭제");

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;

            this.Size = Properties.Settings.Default.WindowSize;
            this.Location = Properties.Settings.Default.WindowLocation;

            this.WindowState = FormWindowState.Minimized;
            //this.StartPosition = FormStartPosition.Manual;

            this.Activate();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(Properties.Resources.msg_error_get_user, "test"), Properties.Resources.msg_caption_warning);
        }
    }
}

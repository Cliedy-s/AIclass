using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _1029_02_RegistryPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 내 폼을 닫을 때의 위치와 사이즈 저장
            WriteRegKey(@"Software\MyGudi\AnyMessenger", "MainLeft", this.Left); //현재 폼의 Left 저장
            WriteRegKey(@"Software\MyGudi\AnyMessenger", "MainTop", this.Top); //현재 폼의 Top 저장
            WriteRegKey(@"Software\MyGudi\AnyMessenger", "MainWidth", this.Width); //현재 폼의 Width 저장
            WriteRegKey(@"Software\MyGudi\AnyMessenger", "MainHeight", this.Height); //현재 폼의 Height 저장
        }

        private void WriteRegKey(string keyString, string keyName, object keyValue)
        {
            Registry.CurrentUser.CreateSubKey(keyString).SetValue(keyName, keyValue);
            Registry.CurrentUser.Close();

        }
        private object ReadRegKey(string keyString, string keyName, object DefaultValue)
        {
            try
            {
                object ReadKey = Registry.CurrentUser.CreateSubKey(keyString).GetValue(keyName, DefaultValue);
                Registry.CurrentUser.Close();
                if (ReadKey == null)
                {
                    Registry.CurrentUser.CreateSubKey(keyString).SetValue(keyName, DefaultValue);
                    ReadKey = DefaultValue;
                }
                return ReadKey;
            }
            catch (Exception ex)
            {
                return DefaultValue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Convert.ToInt32(ReadRegKey(@"Software\MyGudi\AnyMessenger", "MainLeft", this.Left));
            this.Top = Convert.ToInt32(ReadRegKey(@"Software\MyGudi\AnyMessenger", "MainTop", this.Top));
            this.Width = Convert.ToInt32(ReadRegKey(@"Software\MyGudi\AnyMessenger", "MainWidth", this.Width));
            this.Height = Convert.ToInt32(ReadRegKey(@"Software\MyGudi\AnyMessenger", "MainHeight", this.Height));
        }
    }
}

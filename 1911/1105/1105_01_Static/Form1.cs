using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1105_01_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Global global;
        private void Form1_Load(object sender, EventArgs e)
        {
            global = new Global();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //입력값 유효성 체크
            //db를 읽어서 유효한 사용자 체크
            //global클래스 저장
            global.instanceUserID = textBox1.Text;
            Global.staticUserID = textBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("staticUserID : {0} \n", Global.staticUserID);
            sb.AppendFormat("instanceUserID : {0} \n", global.instanceUserID);
            MessageBox.Show(sb.ToString());
        }

    }
}

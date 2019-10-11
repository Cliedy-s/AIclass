using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0918_02_Singleton
{
    public partial class Form2 : Form
    {
        static Form2 frm2;
        static int count=0;
        public static Form2 CreateForm2()
        {
            if (frm2 == null) { 
                frm2 = new Form2();
            }
            count++;
            return frm2;
        }
        private Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("닫으시겠습니까?", "닫기", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
            {
                // 종료x 
                e.Cancel = true; // 종료를 취소한다.
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // frm2 => frm2.IsDisposed
            frm2 = null; // dispose가 제대로 안됐기 때문에 싱글톤 사용시 변수에 null을 줘야함
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

    }

}

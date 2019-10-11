using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_01_성적계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //double korScore = double.Parse(txtKorScore.Text);
            //double mathScore = double.Parse(txtMathScore.Text);
            //double engScore = double.Parse(txtEngScore.Text);

            double sum = double.Parse(txtKorScore.Text)+ double.Parse(txtMathScore.Text) + double.Parse(txtEngScore.Text);

            txtTotalResult.Text = string.Format("{0}", sum);
            txtAverage.Text = string.Format("{0:F2}", sum / 3);
        }

        private void TxtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ShowMessageBox = ConfigurationManager.AppSettings["ShowMessageBox"];

            //bool bCheck = Char.IsNumber(e.KeyChar) || (e.KeyChar == '.');
            bool bCheck = Char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == (char)Keys.Back);
            if (!bCheck)
            {
                if(ShowMessageBox == "true") MessageBox.Show("숫자를 입력하세요");
                e.Handled = true;
            }
            //if (e.KeyChar > (char)Keys.D0 && e.KeyChar < (char)Keys.D9)
            //{
            //    e.Handled = true;
            //}
        }
    }
}

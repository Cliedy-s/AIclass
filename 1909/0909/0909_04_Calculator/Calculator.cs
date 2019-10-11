using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0909_04_Calculator
{
    public partial class Calculator : Form
    {
        double value1 = 0, value2 = 0, result = 0;
        string preOp = "+", senderOp = string.Empty;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderBtn = sender as Button;
            if (senderOp == "=") BtnCE_Click(sender, e);

            if (value2 == 0)
            {
                value2 = double.Parse(senderBtn.Text);
            }
            else
            {
                value2 = double.Parse(value2.ToString() + senderBtn.Text);
            }
            txtCal.Text = value2.ToString();
            Console.WriteLine(value2);
        }

        private void OperatorBtn_Click(object sender, EventArgs e)
        {
            Button senderBtn = sender as Button;

            senderOp = senderBtn.Text;
            #region preOp연산
            switch (preOp)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    if (value2 == 0)
                    {
                        txtCal.Text = "0으로 나눌 수 없습니다.";
                        return;
                    }
                    result = value1 / value2;
                    break;
            }
            #endregion

            txtCal.Text = result.ToString();
            value1 = result;
            if (senderBtn.Text != "=")
            {
                value2 = 0;
                preOp = senderBtn.Text;
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            Keys t = e.KeyCode;
        }

        //
        private void BtnCE_Click(object sender, EventArgs e)
        {
            value2 = 0;
            txtCal.Text = "";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            value1 = value2 = result = 0;
            preOp = "+";
        }
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            string str = value2.ToString();
            if (str.Length == 1)
                value2 = 0;
            else
                value2 = double.Parse(str.Substring(0, str.Length - 1));
            txtCal.Text = value2.ToString();
        }
    }
}

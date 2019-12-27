using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmCalc : Form
    {
        int leftValue = 0, rightValue = 0, result = 0;
        string preOperator = "+";

        public frmCalc()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            if (rightValue == 0)
                rightValue = int.Parse(b1.Text);
            else
                rightValue = int.Parse(rightValue.ToString() + b1.Text);
            txtCal.Text = rightValue.ToString();
        }
        
        private void FrmCalc_KeyDown(object sender, KeyEventArgs e)
        {
            string numPad = string.Empty;
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                numPad = (((int)e.KeyCode) - 96).ToString();

                if (rightValue == 0)
                    rightValue = int.Parse(numPad);
                else
                    rightValue = int.Parse(rightValue.ToString() + numPad);
                txtCal.Text = rightValue.ToString();
            }
            else
            {
                if (e.KeyCode == Keys.Add)
                    this.button11.PerformClick();
                else if (e.KeyCode == Keys.Subtract)
                    this.button12.PerformClick();
                else if (e.KeyCode == Keys.Multiply)
                    this.button13.PerformClick();
                else if (e.KeyCode == Keys.Divide)
                    this.button14.PerformClick();
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            switch (preOperator)
            {
                case "+":
                    result = leftValue + rightValue;
                    break;
                case "-":
                    result = leftValue - rightValue;
                    break;
                case "*":
                    result = leftValue * rightValue;
                    break;
                case "/":
                    if (rightValue == 0)
                    {
                        MessageBox.Show("0으로 나눌수 없습니다.");
                        return;
                    }
                    else
                        result = leftValue / rightValue;
                    break;
            }
            Button b1 = (Button)sender;
            preOperator = b1.Text;
            txtCal.Text = result.ToString();
            leftValue = result;
            rightValue = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCal.Text = "";
            leftValue = 0;
            rightValue = 0;
            preOperator = "+";
        }
    }
}

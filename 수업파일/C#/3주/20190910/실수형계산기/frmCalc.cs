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
        double leftValue = 0.0, rightValue = 0.0, result = 0.0;
        string preOperator = "+";

        public frmCalc()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            if (b1.Text.EndsWith("."))
            {
                txtCal.Text += b1.Text;
                rightValue = rightValue * 1.0;
            }
            else
            {
                if (rightValue == 0.0 && ! txtCal.Text.EndsWith("."))
                    txtCal.Text = b1.Text;                    
                else
                    txtCal.Text += b1.Text;
                rightValue = double.Parse(txtCal.Text);
            }            
        }
        
        private void FrmCalc_KeyDown(object sender, KeyEventArgs e)
        {
            string numPad = string.Empty;
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                numPad = (((int)e.KeyCode) - 96).ToString();

                if (rightValue == 0.0 && !txtCal.Text.EndsWith("."))
                    txtCal.Text = numPad;
                else
                    txtCal.Text += numPad;
                rightValue = double.Parse(txtCal.Text);
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                txtCal.Text += ".";
                rightValue = rightValue * 1.0;
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
                    if (rightValue == 0.0)
                    {
                        MessageBox.Show("0으로 나눌수 없습니다.");
                        return;
                    }
                    else
                        result = leftValue / rightValue;
                    break;
            }
            Button b1 = (Button)sender;
            if (b1.Text != "=")
            {
                preOperator = b1.Text;
                rightValue = 0.0;
            }
            txtCal.Text = result.ToString();
            leftValue = result;            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCal.Text = "";
            leftValue = 0.0;
            rightValue = 0.0;
            preOperator = "+";
        }
    }
}

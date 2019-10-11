using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0904_03_WinForm
{
    public partial class Form1 : Form // 메서드 3개만 쓰기 // (5+3) <= (-) 계산 // exe로 보내기 파일명에 이름 붙이기
    {
        int value1=0, value2=0;
        string op = string.Empty;

        public Form1()
        {
            InitializeComponent(); // => 디자이너 메소드 실행
        }

        private void Button_Click(object sender, EventArgs e) // sender : 이벤트를 일으킨 객체, EventArgs : ? 줄거없음????
        {
            this.txtCal.Text += (sender as Button).Text;
        }

        private void OperatorBtn_Click(object sender, EventArgs e)
        {
            int val = int.Parse(txtCal.Text);

            if (op == null) value1 = val;
            else
            {
                switch (op)
                {
                    case "+":
                        value1 += value2;
                        break;
                    case "-":
                        value1 -= value2;
                        break;
                    case "*":
                        value1 *= value2;
                        break;
                    case "/":
                        value1 /= value2;
                        break;
                    default:
                        break;
                }

            }

            op = (sender as Button).Text;
        }
    }
}

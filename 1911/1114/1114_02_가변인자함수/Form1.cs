using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1114_02_가변인자함수
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Sum(params int[] ints)
        {
            int sum = 0;
            foreach (int item in ints)
            {
                sum += item;
            }
            return sum;
        }
        public int SumOther(int[] ints)
        {
            int sum = 0;
            foreach (int item in ints)
            {
                sum += item;
            }
            return sum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Sum(1,2,3,4,5,6,7,8,9,10).ToString();
            label1.Text = SumOther(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 123;
            int b = 456;
            //string interpolation
            label1.Text = $"a : {a}, b : {b}"; // 인터폴레이션
            label1.Text = string.Format($"a : {a}, b : {b}"); // 왜 되지?
            //label1.Text = $"{{a}} + {b} = {a + b}"; // 포멧쓰면 안댐
            MessageBox.Show($"{{a}} + {b} = {a + b}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Abs(3).ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public delegate void ItemAdd(string str);
        private ItemAdd listitemadd;

        public Form1()
        {
            InitializeComponent();
        }

        private void ListAdd(string str)
        {
            listBox1.Items.Add(str);
        }

        private void ListView()
        {
            //MessageBox.Show("새로운 쓰레드 작업시작");
            //int tot = 0;
            //for (int i = 1; i < 100000; i++)
            //{
            //    tot += i;
            //}
            //MessageBox.Show(tot.ToString());

            for (int i = 1; i < 100000; i++)
            {
                //listBox1.Items.Add("현재의 값은 " + i.ToString());
                listBox1.Invoke(listitemadd, i.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //for(int i=1; i<100000; i++)
            //{
            //    listBox1.Items.Add("현재의 값은 " + i.ToString());
            //}

            listitemadd = new ItemAdd(ListAdd);

            Thread T1 = new Thread(new ThreadStart(ListView));
            T1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭하셨네요");
        }
    }
}

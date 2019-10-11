using System;
using System.Threading;
using System.Windows.Forms;

namespace _0925_03_MultiThread
{
    public partial class Form1 : Form
    {
        public delegate void threadDelegate(string str);
        threadDelegate threadD;
       // threadDelegate threadD02;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            threadD += (str) =>  listBox1.Items.Add(str) ;
            //threadD02 += ListPrint;
            Thread thread = new Thread(threadMethod); // new ThreadStart(threadMethod), new ParameterizedThreadStart(threadMethod);
            //Thread thread02 = new Thread(ListShow);
            thread.Start();
            //thread02.Start();
        }

        //public void ListShow()
        //{
        //    for (int i = 0; i < 100000; i++)
        //    {
        //        listBox1.Invoke(threadD02, i.ToString());
        //    }
        //}
        public void ListPrint(string str)
        {
            listBox1.Items.Add(str);
        }


        public void threadMethod()
        {
            // ? => 왜 에러가 안뜨징 : 디버그에서는 뜸
            //listBox1.Items.Add("스레드를 시작합니다.."); // 컨트롤에 접근하려하면 에러 => 주 스레드가 만든 컨트롤이기때문..?
            for (int i = 1; i < 100000; i++)
            {
                listBox1.Invoke(threadD, ("현재의 값은 " + i.ToString())); // => 스레드 구분.. , 해당 컨트롤을 만든 스레드가 함수를 실행하게 함.
                //threadD(i.ToString()); // => 크로스 에러
            }
            threadD = null;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭하셨네요.");
        }
    }
}

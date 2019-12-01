using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1121_03_AsyncAwait
{
    public partial class Form1 : Form
    {
        public delegate void threadDelegate(string str);
        threadDelegate threadD;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            threadD += (str) => listBox1.Items.Add(str);
            Thread thread = new Thread(threadMethod);
            thread.Start();
        }
        private int LongCalcAsync(int times)
        {
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }
        public void ListPrint(string str)
        {
            listBox1.Items.Add(str);
        }
        // 동기 호출 함수
        public void threadMethod()
        {
            for (int i = 1; i < 100000; i++)
            {
                listBox1.Invoke(threadD, ("현재의 값은 " + i.ToString()));
            }
            threadD = null;
        }

        // 비동기 호출 함수
        private async void Run()
        {
            // 부 스레드 실행
            var task1 = Task.Run(() => LongCalcAsync(10));
            int sum = await task1; // 값이 올 때까지 기다린다.

            // 주 스레드 실행
            this.label1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭하셨네요.");
        }

    }
}

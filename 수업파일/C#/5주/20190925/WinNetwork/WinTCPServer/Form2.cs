using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WinTCPServer
{
    public partial class Form2 : Form
    {
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;

        private UdpClient myServer;
        private IPEndPoint receivePoint;
        private Encoding Default = Encoding.Default;

        public Form2()
        {
            InitializeComponent();
        }

        private void ListShow(string strMsg)
        {
            listBox1.Items.Add(strMsg);
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                listitemadd = new MyItemAdd(ListShow);

                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                myServer = new UdpClient(localAddress);
                Thread startServer = new Thread(new ThreadStart(Start_Server));
                startServer.Start();
            }
            catch (Exception E)
            {
                MessageBox.Show("[에러 발생]:" + E.ToString());
            }
        }

        public void Start_Server()
        {
            while (true)
            {
                listBox1.Invoke(listitemadd, "서버 시작 - 클라이언트의 전송을 기다립니다 ...");

                //데이터그램 수신
                byte[] byteReceive = myServer.Receive(ref receivePoint);
                String strReceive = Default.GetString(byteReceive);
                listBox1.Invoke(listitemadd, "[수신]:" + strReceive + ":" + receivePoint.ToString());

                //서버의 서비스 코드, 여기서는 서버의 현재 날짜와 시간
                DateTime now = DateTime.Now;
                String strSend = "서버의 현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                byte[] byteSend = Default.GetBytes(strSend.ToCharArray());

                //데이터그램을 보낸 호스트로 데이터그램 전송
                myServer.Send(byteSend, byteSend.Length, receivePoint);
                listBox1.Invoke(listitemadd, "[송신]: " + strSend);
            }
        }
    }
}

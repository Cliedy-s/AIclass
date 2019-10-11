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
using System.Net;
using System.Net.Sockets;

namespace WinTCPServer
{
    public partial class WinTCPServer : Form
    {
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;

        private TcpListener myListener;
        private Encoding Default = Encoding.Default;

        public WinTCPServer()
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

                IPEndPoint localAddress = new IPEndPoint(
                          IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                myListener = new TcpListener(localAddress);
                myListener.Start();

                Thread startServer = new Thread(new ThreadStart(Start_Server));
                startServer.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show("[에러 발생]:" + err.ToString());
            }
        }

        public void Start_Server()
        {
            while (true)
            {
                listBox1.Invoke(listitemadd, "서버 시작 - 클라이언트의 접속을 기다립니다...");

                Socket mySocket = myListener.AcceptSocket();

                if (mySocket.Connected)
                {
                    Byte[] byteReceive = new Byte[128];

                    int i = mySocket.Receive(byteReceive, byteReceive.Length, 0);

                    string strReceive = Default.GetString(byteReceive);

                    string strSend = "서버의 현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    Byte[] byteSend = Default.GetBytes(strSend.ToCharArray());

                    mySocket.Send(byteSend, byteSend.Length, 0);

                    mySocket.Shutdown(SocketShutdown.Both);
                    mySocket.Close();
                }
            }
        }
    }
}

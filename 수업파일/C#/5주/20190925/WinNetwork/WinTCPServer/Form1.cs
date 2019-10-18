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
    public partial class Form1 : Form
    {
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;

        private TcpListener myListener;
        private Encoding Default = Encoding.Default;

        public Form1()
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
                //listBox1.Items.Add("서버 시작 - 클라이언트의 접속을 기다립니다...");
                listBox1.Invoke(listitemadd, "서버 시작 - 클라이언트의 접속을 기다립니다...");

                //클라이언트의 접속을 기다림
                Socket mySocket = myListener.AcceptSocket();

                if (mySocket.Connected)
                {
                    //listBox1.Invoke(listitemadd, "클라이언트 접속됨.." + mySocket.RemoteEndPoint.ToString());

                    Byte[] byteReceive = new Byte[128];

                    //클라이언트가 보내준 데이터를 받음		
                    int i = mySocket.Receive(byteReceive, byteReceive.Length, 0);

                    //Default 형식으로 되 있는 byte 배열을 String 형으로 변환		
                    string strReceive = Default.GetString(byteReceive);
                    //listBox1.Invoke(listitemadd, "[수신]:" + strReceive);

                    //현재 시간을 얻어서 String 형으로 변환	
                    string strSend = "서버의 현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //String 형을 Default 형식의 byte 배열로 변환		
                    Byte[] byteSend = Default.GetBytes(strSend.ToCharArray());

                    //클라이언트에게 데이터를 보냄		
                    mySocket.Send(byteSend, byteSend.Length, 0);

                    //listBox1.Invoke(listitemadd, "[송신]:" + strSend);
                    mySocket.Shutdown(SocketShutdown.Both);
                    mySocket.Close();
                }
            }
        }
    }
}

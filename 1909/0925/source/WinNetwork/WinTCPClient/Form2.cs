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

namespace WinTCPClient
{
    public partial class Form2 : Form
    {
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;

        private UdpClient myClient;
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                listitemadd = new MyItemAdd(ListShow);

                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                myClient = new UdpClient(clientAddress);
                listBox1.Items.Add("서버에 접속했습니다 ...");
                Thread startClient = new Thread(new ThreadStart(Start_Client));
                startClient.Start();
            }
            catch (Exception E)
            {
                listBox1.Items.Add(E.ToString() + "때문에 서버에 연결할 수 없습니다");
            }
        }

        public void Start_Client()
        {
            bool continueLoop = true;

            while (continueLoop)
            {
                string strSend = "서버의 시간을 보내주세요";
                Byte[] byteSend = Default.GetBytes(strSend.ToCharArray());

                //서버로 데이터그램 전송
                myClient.Send(byteSend, byteSend.Length, txtIP_S.Text, int.Parse(txtPort_S.Text));
                listBox1.Invoke(listitemadd, "[송신]: " + strSend);

                //서버로부터 데이터그램 수신		
                byte[] byteReceive = myClient.Receive(ref receivePoint);
                string strReceive = Default.GetString(byteReceive);
                listBox1.Invoke(listitemadd, "[수신]: " + strReceive);

                myClient.Close();
                listBox1.Invoke(listitemadd, "서버와 접속이 끊어졌습니다!!");
                continueLoop = false;
            }
        }
    }
}

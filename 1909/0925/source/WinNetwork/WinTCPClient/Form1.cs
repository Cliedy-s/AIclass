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
    public partial class Form1 : Form
    {
        private TcpClient myClient;
        private NetworkStream myNts;
        private Encoding Default = Encoding.Default;
        
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;

        public Form1()
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
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(txtIP_S.Text), int.Parse(txtPort_S.Text));

                myClient = new TcpClient(clientAddress);
                myClient.Connect(serverAddress);

                listBox1.Items.Add("서버에 접속했습니다..");

                //전송 및 수신을 하기위해 Network Stream을 얻는다.		
                myNts = myClient.GetStream();
                Thread startClient = new Thread(new ThreadStart(Start_Client));
                startClient.Start();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString() + "때문에 서버에 접속할 수 없습니다");
            }
        }

        public void Start_Client()
        {
            bool continueLoop = true;

            while (continueLoop)
            {
                string strSend = "서버의 시간을 보내주세요";
                Byte[] byteSend = Default.GetBytes(strSend.ToCharArray());

                //서버한테 송신
                myNts.Write(byteSend, 0, byteSend.Length);

                //버퍼에 있는 스트림을 flush  
                myNts.Flush();
                listBox1.Invoke(listitemadd, "[송신]:" + strSend);


                byte[] byteReceive = new byte[128];
                int i = myNts.Read(byteReceive, 0, 128);

                //서버에서 수신
                string strReceive = Default.GetString(byteReceive);
                listBox1.Invoke(listitemadd, "[수신]:" + strReceive);
                myNts.Close();
                myClient.Close();
                listBox1.Invoke(listitemadd, "서버와 접속이 끊어졌습니다!!");

                //더 이상 할 일이 없기 때문에 루프 탈출            
                continueLoop = false;
            }
        }
    }
}

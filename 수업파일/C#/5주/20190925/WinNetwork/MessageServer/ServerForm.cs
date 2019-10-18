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
using System.Collections;

namespace MessageServer
{
    public partial class ServerForm : Form
    {
        public delegate void MyItemAdd(string str);
        private MyItemAdd listitemadd;
        
        private Thread serverThread;
        private TcpListener serverListener;

        //서버에 접속한 클라이언트의 GUID와 객체를 가지고 있는 해쉬 테이블
        private Hashtable clientTable;
                
        public ServerForm()
        {
            InitializeComponent();

            listitemadd = new MyItemAdd(ListShow);
            clientTable = new Hashtable();

            serverThread = new Thread(new ThreadStart(startListen));
            serverThread.Start();
            ListShow("메신저 서버 시작");
        }

        public void startListen()
        {
            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1980);
                serverListener = new TcpListener(localAddress);
                serverListener.Start();
                do
                {
                    //새로운 클라이언트가 접속할 때마다 새로운 User 클래스를 만든다
                    User newClient = new User(serverListener.AcceptTcpClient());

                    //새로 생성된 User 클래스에 델리게이트를 붙임
                    newClient.Disconnected += new DisconnectDelegate(OnDisconnected);
                    newClient.Connected += new ConnectDelegate(this.OnConnected);
                    newClient.MessageReceived += new MessageDelegate(OnMessageReceived);

                    newClient.Connect();
                }
                while (true);
            }
            catch
            {
                serverListener.Stop();
            }
        }

        //User 클래스에서 Connected 이벤트가 발생했을 때 콜백되는 이벤트 핸들러
        public void OnConnected(object sender, EventArgs e)
        {
            //새로 접속한 User 클래스
            User temp = (User)sender;

            //새로 접속한 User 클래스의 GUID와 
            //User 클래스 객체를 해쉬테이블에 추가 
            clientTable.Add(temp.ID, temp);
            User tempClient;
            AddLog("클라이언트 접속됨:" + temp.UserName);

            //해쉬 테이블에 있는 모든 User 클래스들(서버에 접속한 클라이언트들)
            //에게 새로운 클라이언트가 접속했음을 알림
            foreach (DictionaryEntry d in clientTable)
            {
                tempClient = (User)d.Value;
                tempClient.SendMsg(tempClient.ID + "@접속됨@" + temp.UserName);
            }
        }

        //User 클래스에서 DisConnected 이벤트가 발생했을 때 콜백되는 이벤트 핸들러
        public void OnDisconnected(object sender, EventArgs e)
        {
            //접속인 끊어진 User 클래스
            User temp = (User)sender;

            //접속이 끊어진 User 클래스가 해쉬 테이블에 있으면
            if (clientTable.ContainsKey(temp.ID))
            {
                AddLog("클라이언트 접속 끊김:" + temp.UserName);
                //ServerForm 클래스가 관리하는 해쉬테이블에서 제거
                clientTable.Remove(temp.ID);
                //UserInfoList 클래스가 관리하는 해쉬테이블에서 제거
                UserInfoList.RemoveClient(temp.UserName, temp.ID);
                User tempClient;
                //접속해 있는 모든 클라이언트들에게 
                //클라이언트 하나가 연결이 끊겼음을 알림
                foreach (DictionaryEntry d in clientTable)
                {
                    tempClient = (User)d.Value;
                    tempClient.SendMsg(tempClient.ID + "@접속끊김@" + temp.UserName);
                }
            }
        }

        //User 클래스에서 MessageReceived 이벤트가 발생했을 때 콜백되는 이벤트 핸들러
        public void OnMessageReceived(object sender, MessageEventArgs e)
        {
            //메세지를 보낸 User 클래스
            User temp = (User)sender;
            string str = "[ " + temp.UserName + " ]" + " : " + e.Message;
            AddLog(str);
            User tempClient;
            //한 클라이언트가 보낸 메세지를
            //서버에 연결된 모든 클라이언트들에게 전송
            foreach (DictionaryEntry d in clientTable)
            {
                tempClient = (User)d.Value;
                tempClient.SendMsg(str);
            }
        }

        public void AddLog(string msg)
        {
            logBox.Invoke(listitemadd, msg);
        }

        private void ListShow(string strMsg)
        {
            logBox.Items.Add(strMsg);
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverListener.Stop();
        }
    }
}

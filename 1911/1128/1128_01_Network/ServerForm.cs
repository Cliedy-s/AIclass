using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections;

namespace _1128_01_MessengerServer
{
    public partial class ServerForm : Form
    {
        public delegate void MyListItemAdd(string msg);
        Thread serverThread;
        MyListItemAdd listItemAdd;
        TcpListener serverListener = null;

        public ServerForm()
        {
            InitializeComponent();
        }
        private void ServerForm_Load(object sender, EventArgs e)
        {
        }
        IPEndPoint serverAddress = null;
        private void StartListen()
        {
            try
            { 
                serverListener = new TcpListener(serverAddress);
                serverListener.Start();
                while (true)
                {
                    User client = new User(serverListener.AcceptTcpClient());
                    client.Connected += new EventHandler(OnConnected) ;
                    client.Disconnected += OnDisconnected;
                    client.MessageReceive += OnMessageReceived;
                    client.Connect();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                serverListener.Stop();
            }
        }
        private void OnMessageReceived(object sender, MessageEventArgs args)
        {
            // 서버쪽 로그에 메세지 기록
            User user = sender as User;
            lstLogBox.Invoke(listItemAdd, $"[{user.Username}] : {args.Message}");

            // 접속한 클라이언트들에게 브로드캐스트
            foreach (KeyValuePair<string, User> item in UserInfoList.GetAllUserObjects())
            {
                (item.Value).SendMessage($"s@msg@[{user.Username}] : {args.Message}");
            }
        }
        private void OnDisconnected(object sender, EventArgs e)
        {
            User user = sender as User;
            if (UserInfoList.IsContains(user.GUID))
            {
                //로그에 로그아웃 기록
                lstLogBox.Invoke(listItemAdd, "클라이언트 접속 종료됨 : " + user.Username);

                // 클라이언트 목록에서 삭제
                UserInfoList.RemoveClient(user);

                // 클라이언트들에게 로그아웃 메시지 브로드캐스트
                foreach (KeyValuePair<string, User> item in UserInfoList.GetAllUserObjects())
                {
                    (item.Value).SendMessage(user.GUID + "@접속 종료됨@" + user.Username);
                }
            }
        }
        private void OnConnected(object sender, EventArgs e)
        {
            User user = sender as User;
            lstLogBox.Invoke(listItemAdd, "클라이언트 접속됨 : " + user.Username);

            foreach (KeyValuePair<string, User> item in UserInfoList.GetAllUserObjects())
            {
                if (item.Key == user.GUID)
                    continue;
                (item.Value).SendMessage(user.GUID + "@접속됨@" + user.Username);
            }
        }
        private void ListShow(string msg)
        {
            lstLogBox.Items.Add(msg);
        }
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverListener.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {// IPOpen
            button1.Enabled = false;
            serverAddress = new IPEndPoint(IPAddress.Parse("192.168.0.10"), 2019);
            serverThread = new Thread(() => StartListen());
            listItemAdd = new MyListItemAdd(ListShow);
            serverThread.Start();
            lstLogBox.Items.Add("메신저 서버시작");
        }
        private void button1_Click(object sender, EventArgs e)
        { //LocalOpen

            button2.Enabled = false;
            serverAddress = new IPEndPoint(IPAddress.Loopback, 2019);
            serverThread = new Thread(() => StartListen());
            listItemAdd = new MyListItemAdd(ListShow);
            serverThread.Start();
            lstLogBox.Items.Add("메신저 서버시작");
        }
    }
}

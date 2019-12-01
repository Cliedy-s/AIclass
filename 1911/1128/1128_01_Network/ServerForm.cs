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
            serverThread = new Thread(() => StartListen());
            listItemAdd = new MyListItemAdd(ListShow);
        }
        private void StartListen()
        {
            try
            { 
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2019);
                serverListener = new TcpListener(serverAddress);
                serverListener.Start();
                while (true)
                {
                    User client = new User(serverListener.AcceptTcpClient());
                    client.Connected += new EventHandler(OnConnected) ;
                    client.Disconnected += OnDisconnected;
                    client.MessageReceive += OnMessageReceived;
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
            throw new NotImplementedException();
        }
        private void OnDisconnected(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void OnConnected(object sender, EventArgs e)
        {
            User user = sender as User;
            lstLogBox.Invoke(listItemAdd, "클라이언트 접속됨 : " + user.Username);
            //lstLogBox.Invoke((msg) => { lstLogBox.Items.Add(msg); }, "클라이언트 접속됨"); //왜 안되지?

            foreach (KeyValuePair<string, User> item in UserInfoList.GetAllUserOjbects())
            {
                (item.Value).SendMessage(user.GUID + "@접속됨@" + user.Username);
            }
        }
        private void ListShow(string msg)
        {
            lstLogBox.Items.Add(msg);
        }
        private void ServerForm_Load(object sender, EventArgs e)
        {
            serverThread.Start();
            lstLogBox.Items.Add("메신저 서버시작");
        }
        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverListener.Stop();
        }
    }
}

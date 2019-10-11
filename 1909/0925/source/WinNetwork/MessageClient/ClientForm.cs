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

namespace MessageClient
{
    public partial class ClientForm : Form
    {
        public delegate void displayMessage(string msg);

        private string userID, userName;
        bool firstTime = true;
        private TcpClient chatClient;
        private byte[] recByte = new byte[1024];
        private Encoding Default = Encoding.Default;

        public ClientForm()
        {
            InitializeComponent();
        }

        public void GetStreamMsg(IAsyncResult ar)
        {
            int byteCount;
            try
            {
                byteCount = (chatClient.GetStream()).EndRead(ar);

                //서버와 접속이 끊김
                if (byteCount < 1)
                {
                    Disconnect();
                    MessageBox.Show("접속끊김!!");
                    return;
                }
                //메세지 해석
                BuildText(recByte, 0, byteCount);

                //비동기 수신 시작
                if (!firstTime)
                {
                    AsyncCallback GetMsgCallback = new AsyncCallback(GetStreamMsg);
                    (chatClient.GetStream()).BeginRead(recByte, 0, 1024, GetMsgCallback, this);
                }
            }
            catch (Exception ed)
            {
                Disconnect();
                MessageBox.Show("Exception Occured :" + ed.ToString());
            }
        }

        public void BuildText(byte[] dataByte, int offset, int count)
        {
            string tmp = Default.GetString(dataByte, offset, count);

            char[] spliters = { '@' };
            //서버로부터 온 첫번째 메세지이면
            if (firstTime)
            {
                //분리자 '@'로 토큰으로 나눔
                string[] tempString = tmp.Split(spliters);

                //사용자 아이디 에러
                if (tempString[0] == "미안합니다")
                {
                    object[] temp = { tempString[1] };
                    this.Invoke(new displayMessage(DisplayText), temp);
                    Disconnect();
                }
                else
                {
                    //클라이언트의 GUID
                    this.userID = tempString[0];

                    for (int i = 1; i < tempString.Length; i++)
                    {
                        //서버에 접속한 사용자 아이디
                        object[] temp = { tempString[i] };

                        //UI(user interface) 쓰레드가 아닌 Worker 쓰레드이므로
                        //Invoke()를 호출해서 listbox를 업데이트 해야 한다
                        this.Invoke(new displayMessage(AddUser), temp);
                    }

                    firstTime = false;

                    AsyncCallback GetMsgCallback = new AsyncCallback(GetStreamMsg);
                    (chatClient.GetStream()).BeginRead(recByte, 0, 1024, GetMsgCallback, this);
                }

            }

            //서버와 처음으로 주고 받는 메세지가 아닌경우
            //즉 이벤트내용(접속됨, 접속끊김)이거나 체팅 내용을 담고 있는 메세지 인경우
            else
            {

                //자신의 GUID가 있다면 이벤트 내용
                if (tmp.IndexOf(this.userID) >= 0)
                {
                    string[] tempString = tmp.Split(spliters);
                    //새로운 사용자가 접속
                    if (tempString[1] == "접속됨")
                    {
                        object[] temp = { tempString[2] };
                        this.Invoke(new displayMessage(AddUser), temp);
                    }
                    //기존의 사용자 접속 끊음
                    else if (tempString[1] == "접속끊김")
                    {
                        object[] temp = { tempString[2] };
                        this.Invoke(new displayMessage(RemoveUser), temp);
                    }
                }
                else
                {
                    //체팅 내용
                    tmp += "\r\n";
                    object[] temp = { tmp };
                    //DisplayText 
                    this.Invoke(new displayMessage(DisplayText), temp);
                }
            }
        }

        private void RemoveUser(string user)
        {
            if (userlistBox.Items.Contains(user))
                userlistBox.Items.Remove(user);

            DisplayText(user + " 채팅방을 떠나셨습니다\r\n");
        }

        private void AddUser(string user)
        {
            if (!userlistBox.Items.Contains(user))
                userlistBox.Items.Add(user);

            if (!firstTime)
                DisplayText(user + " 채팅방에 참여하셨습니다.\r\n");
        }

        //Method to send a message to the server
        public void SendMsg(string msg)
        {
            NetworkStream myNts = chatClient.GetStream();
            msg += "\r\n";
            Byte[] byteSend = Default.GetBytes(msg.ToCharArray());
            myNts.Write(byteSend, 0, byteSend.Length);
            myNts.Flush();
        }

        //Method to Display Text in the TextBox
        public void DisplayText(string msg)
        {
            msgViewBox.AppendText(msg);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //If user Cliked Connect
            if (connectButton.Text == "접속" && usernameBox.Text != "")
            {
                try
                {
                    //서버에 접속
                    IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), DateTime.Now.Millisecond);
                    IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1980);
                    chatClient = new TcpClient(localAddress);
                    chatClient.Connect(serverAddress);
                    DisplayText("서버에 접속됨 ...\r\n");

                    //비동기 수신 시작
                    AsyncCallback GetMsgCallback = new AsyncCallback(GetStreamMsg);
                    (chatClient.GetStream()).BeginRead(recByte, 0, 1024, GetMsgCallback, null);

                    //사용자 아이디 전송
                    SendMsg(usernameBox.Text);
                    this.userName = usernameBox.Text;

                    string tmp = " [" + userName + "]";
                    this.Text += tmp;
                    usernameBox.Text = "";
                    connectButton.Text = "종료";
                    usernameBox.Enabled = false;
                    sendBox.Enabled = true;
                    this.AcceptButton = null;
                    sendBox.Focus();
                }
                catch(Exception err)
                {
                    Disconnect();
                    MessageBox.Show("서버에 접속할 수 없습니다..." + err.Message);
                }
            }
            else if (connectButton.Text == "종료")
            {
                Close();
            }
        }

        private void sendBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && sendBox.Text != "")
            {
                //클라이언트의 체팅 내용 전송
                SendMsg(sendBox.Text);
                sendBox.Text = "";
            }
        }

        private void Disconnect()
        {
            if (chatClient != null)
            {
                chatClient.Close();
                chatClient = null;
            }
            //Reset the Buttons and Variables
            userlistBox.Items.Clear();
            connectButton.Text = "접속";
            usernameBox.Enabled = true;
            sendBox.Enabled = false;
            this.AcceptButton = connectButton;
            firstTime = true;
            userID = "";
            usernameBox.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1128_02_MessengerClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        byte[] recBytes = new byte[1024]; // 바이트를 받을 바이트 배열
        TcpClient me = null;  // 클라이언트
        string userid = string.Empty, username = string.Empty;
        public Action<string> DisplayMessage;
        public Action<string> DisplayUser;
        public Action<string> UndisplayUser;
        bool firstTime = true;
        private void DisplayText(string msg)
        {
            txtMsgViewBox.AppendText(msg + Environment.NewLine);
        }
        private void AddUser(string user)
        {
            lstUserListBox.Items.Add(user);
            if (!firstTime)
                DisplayText(user + " 채팅방에 입장하셨습니다.");
        }
        private void RemoveUser(string user)
        {
            lstUserListBox.Items.Remove(user);
            DisplayText(user + " 채팅방을 떠나셨습니다.");
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            UndisplayUser += RemoveUser;
            DisplayMessage += DisplayText;
            DisplayUser += AddUser;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왜죠");
            if (txtUserNameBox.Text.Trim().Length < 1)
                return;
            if (btnConnect.Text == "Connect")
            {
                MessageBox.Show("왜죠2");
                try
                {
                    string clientip = string.IsNullOrEmpty(txtIP.Text) ? "127.0.0.1" : "192.168.0.10";
                    int clientport = DateTime.Now.Millisecond;
                    string serverip = string.IsNullOrEmpty(txtIP.Text) ? "127.0.0.1" : txtIP.Text;
                    int serverport = string.IsNullOrEmpty(txtPort.Text) ? 2019 : Convert.ToInt32(txtPort.Text);

                    me = new TcpClient(new IPEndPoint(IPAddress.Parse(clientip), clientport));
                    me.Connect(new IPEndPoint(IPAddress.Parse(serverip), serverport)); // 서버
                    DisplayText("서버에 접속됨...");

                    // 비동기 수신 시작
                    me.GetStream().BeginRead(recBytes, 0, recBytes.Length, new AsyncCallback(GetStreamMsg), this);

                    // 사용자 아이디 전송
                    SendMessage(txtUserNameBox.Text.Trim());

                    // 폼의 텍스트에 닉네임 추가
                    this.Text += txtUserNameBox.Text.Trim();
                    btnConnect.Text = "Disconnect";
                    txtSendBox.Focus();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("@@@@@ 서버 접속 오류@@@::" + ee);
                }
            }
            else
            {
                Disconnect();
            }
        }
        public void SendMessage(string msg)
        {
            byte[] mbyte = Encoding.Default.GetBytes(msg);
            NetworkStream stream = me.GetStream();
            lock (stream)
            {
                stream.Write(mbyte, 0, mbyte.Length);
                stream.Flush();
            }
        }
        private void GetStreamMsg(IAsyncResult ar)
        {
            try
            {

                int bCount = me.GetStream().EndRead(ar);
                if (bCount < 1)
                {
                    MessageBox.Show("접속 끊김");
                    return;
                }
                BuildText(recBytes, 0, bCount); //메세지 해석

                // 비동기 수신 시작
                me.GetStream().BeginRead(recBytes, 0, recBytes.Length, new AsyncCallback(GetStreamMsg), this);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        private void txtSendBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendMessage(txtSendBox.Text.Trim());
                txtSendBox.Text = "";
            }
        }
        private void BuildText(byte[] data, int offset, int count)
        {
            string tmp = Encoding.Default.GetString(data, offset, count);
            if (firstTime)
            {
                string[] tmpArr = { tmp.Substring(0, tmp.IndexOf('@')), tmp.Substring(tmp.IndexOf('@') + 1) };
                if (tmpArr[0] == "다시 입력해주세요")
                { // 다시 입력해주세요@...
                    txtMsgViewBox.Invoke(DisplayMessage, tmpArr[1]);
                }
                else // guid@...
                {
                    this.userid = tmpArr[0];
                    string[] users = tmpArr[1].Split('@');
                    foreach (string user in users)
                    {
                        lstUserListBox.Invoke(DisplayUser, user);
                    }
                    firstTime = false;
                }
            }
            else
            {
                // 첫번째 @로 짜름
                if (tmp.Contains('@'))
                {
                    string[] tmpArr = { tmp.Substring(0, tmp.IndexOf('@')), tmp.Substring(tmp.IndexOf('@') + 1) };

                    // 서버쪽에서 이벤트에 의해서 메세지가 전송되는 경우
                    string[] tmps = tmpArr[1].Split('@');
                    switch (tmps[0])
                    {
                        case "접속됨": // 접속
                            lstUserListBox.Invoke(DisplayUser, tmps[1]);
                            break;
                        case "접속 종료됨":
                            lstUserListBox.Invoke(UndisplayUser, tmps[1]);
                            break;
                        case "msg":
                            txtMsgViewBox.Invoke(DisplayMessage, tmps[1]);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    txtMsgViewBox.Invoke(DisplayMessage, tmp);
                }
            }
        }
        private void Disconnect()
        {
            if (me != null)
            {
                me.Close();
                me = null;
            }
            lstUserListBox.Items.Clear();
            btnConnect.Text = "Connect";
            firstTime = true;
            userid = "";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _1128_01_MessengerServer
{
    public class User
    {
        private TcpClient client;
        string clientgid;
        string username;
        byte[] recByte;
        bool connected = false;
        bool isFirstMessage = true; //첫 메시지인지?

        public string Username { get => username; set => username = value; }
        public string GUID { get => clientgid; set => clientgid = value; }
        public TcpClient Client { get => client; set => client = value; }

        public event EventHandler Connected;
        public event EventHandler Disconnected;
        public event MessageDelegate MessageReceive;

        public User(TcpClient client)
        {
            this.client = client;
        }

        public void Connect()
        {
            clientgid = Guid.NewGuid().ToString();
            AsyncCallback getStreamMsg = new AsyncCallback(GetStreamMsg);

            // 비동기로 메세지 수신 시작
            recByte = new byte[1024];
            client.GetStream().BeginRead(recByte, 0, recByte.Length, getStreamMsg, null); // 수신 시 시작
        }//연결
        private void GetStreamMsg(IAsyncResult ar)
        {
            int icount;
            lock (client.GetStream()) // 스레드간의 충돌 방지
            {
                icount = client.GetStream().EndRead(ar);
            }
            if (icount < 1) //클라이언트와 접속이 끊긴 상태
            {
                client.Close();
                Disconnected?.Invoke(this, new EventArgs());
                return;
            }
            BuildText(recByte, 0, icount);

            // 메세지 다시 수신
            lock (client.GetStream())
            {
                AsyncCallback getStreamMsgCallback = new AsyncCallback(GetStreamMsg);
                recByte = new byte[1024];
                client.GetStream().BeginRead(recByte, 0, recByte.Length, getStreamMsgCallback, null);
            }
        } // read
        private void BuildText(byte[] data, int offset, int icount)
        {
            string tmp = Encoding.UTF8.GetString(data, offset, icount);
            // 접속 후 처음 온 데이터 => 사용자 아이디정보
            if (isFirstMessage) // 사용자 아이디를 검사
            {
                if(CheckUserName(tmp))

                isFirstMessage = false;
                return;
            }
            MessageReceive?.Invoke(this, new MessageEventArgs() { Message = tmp });
        }// 수신된 메세지를 해석하는 메서드
        private bool CheckUserName(string username)
        {
            string errormsg = string.Empty;
            if (!(username.Length < 10))
                errormsg = ("다시 입력해주세요@사용자 ID는 10글자 이하로 입력해주세요.");
            else if (!UserInfoList.AddClient(username, clientgid, this)) // 이미 등록된 사용자?
                errormsg = ("다른 이름을 입력해주세요@이미 사용중인 아이디입니다.");
            else if (username.Contains("@"))
                errormsg = "다른 이름을 입력해주세요@아이디에 @문자를 사용할 수 없습니다.";

            if (!string.IsNullOrEmpty(errormsg))
            {
                SendMessage(errormsg.ToString());
                Disconnect();
                return false;
            }
            this.Username = username;
            this.connected = true;
            // 이미 접속중인 사용자 목록을 전달
            SendMessage(UserInfoList.GetAllUsers().Insert(0, this.clientgid));
            Connected?.Invoke(this, new EventArgs());
            return true;
        }
        private void Disconnect()
        {
            this.connected = false;
            client.Close();
        }
        public void SendMessage(string msg)
        {
            byte[] mbyte = Encoding.UTF8.GetBytes(msg);
            NetworkStream stream = client.GetStream();
            lock (stream)
            {
                stream.Write(mbyte, 0, mbyte.Length);
                stream.Flush();
            }
        }
    }
    public delegate void MessageDelegate(object sender, MessageEventArgs args);
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

}
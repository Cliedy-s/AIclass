using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections;

namespace MessageServer
{
    //델리게이트(delegate) 선언	
    public delegate void ConnectDelegate(object sender, EventArgs e);
    public delegate void DisconnectDelegate(object sender, EventArgs e);
    public delegate void MessageDelegate(object sender, MessageEventArgs e);

    //MessageEventArgs 정의
    public class MessageEventArgs : EventArgs
    {
        private string msg;

        //Message 속성(property)
        public string Message
        {
            get { return this.msg; }
            set { this.msg = value; }
        }
    }

    public class User
    {
        //발생시킬 이벤트 정의
        public event ConnectDelegate Connected;
        public event DisconnectDelegate Disconnected;
        public event MessageDelegate MessageReceived;

        private bool firstTime = true;
        private bool connected = false;
        private byte[] recByte = new byte[1024];
        private TcpClient myClient;
        private string userName, clientID;

        private Encoding Default = Encoding.Default;

        public User(TcpClient myClient)
        {
            this.myClient = myClient;
        }

        public string UserName
        {
            get { return this.userName; }
        }

        public string ID
        {
            get { return this.clientID; }
        }

        //새로운 클라이언트 접속
        public void Connect()
        {
            //새로운 GUID 생성
            this.clientID = Guid.NewGuid().ToString();

            //비동기 방식으로 메시지 수신 시작
            AsyncCallback GetStreamMsgCallback = new AsyncCallback(GetStreamMsg);
            myClient.GetStream().BeginRead(recByte, 0, 1024, GetStreamMsgCallback, null);
        }       

        public void GetStreamMsg(IAsyncResult ar)
        {
            int intCount;
            try
            {
                //Thread 간에 충돌이 일어나지 않게 스트림 lock 
                lock (myClient.GetStream())
                {
                    //스트림 수신이 완료되면 수신된 크기를 intCount에 할당
                    intCount = myClient.GetStream().EndRead(ar);
                }
                if (intCount < 1)
                {
                    //수신된 스트림이 없다면 클라이언트와 접속이 끊긴상태이므로           
                    //myClient 닫음
                    myClient.Close();

                    if (Disconnected != null)
                    {
                        EventArgs e = new EventArgs();

                        //Disconnected 이벤트 발생시킴
                        Disconnected(this, e);
                    }
                }
                //수신된 메시지 해석을 위해 
                BuildText(recByte, 0, intCount);
                if (!firstTime)
                {
                    //새로운 메시지 수신을 위해 
                    lock (myClient.GetStream())
                    {
                        AsyncCallback GetStreamMsgCallback = new AsyncCallback(GetStreamMsg);
                        myClient.GetStream().BeginRead(recByte, 0, 1024, GetStreamMsgCallback, null);
                    }
                }
            }
            catch
            {
                myClient.Close();

                //Disconnected 이벤트 발생 시킴
                if (Disconnected != null)
                {
                    EventArgs e = new EventArgs();
                    Disconnected(this, e);
                }
            }
        }

        public void Disconnect()
        {
            this.connected = false;
            myClient.Close();
        }

        public void CheckUserName(string userName)
        {
            //사용자 아이디가 20자 이내인지
            if (userName.Length > 20)
            {
                SendMsg("미안합니다@사용자 아이디를 20자 이내로 입력해주세요!");
                Disconnect();
                return;
            }
            //사용자 아이디에 ‘@’ 문자가 있는지
            else if (userName.IndexOf("@") >= 0)
            {
                SendMsg("미안합니다@사용자 아이디에 @ 문자는 사용될 수 없습니다!");
                Disconnect();
                return;
            }
            //중복된 아이디가 아니면 클래스 UserInfoList의 해쉬 테이블에 사용자 아이디와 GUID 추가
            else if (!UserInfoList.AddClient(userName, this.clientID))
            {
                SendMsg("미안합니다@이미 로그온한 사용자 아이디입니다. 다른 아이디를 입력해주세요!");
                Disconnect();
                return;
            }
            else //사용자 아이디에 이상이 없으면 
            {
                this.connected = true;
                this.userName = userName;

                //새로 접속한 클라이언트에게 현재 서버에 접속한 
                //모든 사용자 아이디들을 보내기 위한 StringBuilder
                StringBuilder userList = new StringBuilder();
                userList.Append(this.clientID);  //새로 접속한 클라이언트의 GUID를 userList에 추가

                Hashtable clientTable = UserInfoList.GetList;  //UserInfoList 클래스의 해쉬 테이블을 가져 옴

                //해쉬 테이블에 있는 사용자 아이디를 StringBuilder userList에 추가
                //이때 구분자는 '@'
                foreach (DictionaryEntry item in clientTable)
                {
                    userList.Append("@");
                    userList.Append(item.Value.ToString());
                }
                //메세지 수신
                lock (myClient.GetStream())
                {
                    AsyncCallback GetStreamMsgCallback = new AsyncCallback(GetStreamMsg);
                    myClient.GetStream().BeginRead(recByte, 0, 1024, GetStreamMsgCallback, null);
                }
                //사용자 아이디 정보를 송신
                //150c37ec-a4cb-4520-bdf5-0552d1b50fc9@주동@선주
                //새로접속한 클라이언트의 guid@해쉬에있는 사용자 아이디들
                SendMsg(userList.ToString());

                if (Connected != null)
                {
                    EventArgs e = new EventArgs();
                    //Connected 이벤트 발생 시킴
                    Connected(this, e);
                }
            }
        }

        public void BuildText(byte[] dataByte, int offset, int count)
        {
            string tmp = Default.GetString(dataByte, offset, count);

            if (firstTime) //접속한 후 처음으로 온 데이터면 사용자 아이디 정보이므로
            {
                //사용자 아이디 검사
                CheckUserName(tmp.Trim());
                firstTime = false;
            }
            else if (MessageReceived != null && connected) //사용자들이 보낸 채팅 내용
            {
                MessageEventArgs e = new MessageEventArgs();
                e.Message = tmp.Trim();

                //MessageRecieved 이벤트 발생 시킴
                MessageReceived(this, e);
            }
        }

        public void SendMsg(string msg)
        {
            NetworkStream myNts = myClient.GetStream();
            lock (myNts)
            {
                Byte[] byteSend = Default.GetBytes(msg.ToCharArray());
                myNts.Write(byteSend, 0, byteSend.Length);
                myNts.Flush();
            }
        }
    }

    public class UserInfoList
    {
        private static Hashtable clientTable = new Hashtable();

        public static bool AddClient(string userName, string id)
        {
            lock (clientTable)
            {
                //사용자 아이디가 이미 있는 경우
                if (clientTable.ContainsValue(userName))
                {
                    return false;
                }
                else
                {
                    //GUID와 사용자 아이디를 추가
                    clientTable.Add(id, userName);
                    return true;
                }
            }
        }

        public static bool RemoveClient(string userName, string id)
        {
            lock (clientTable)
            {
                //사용자 아이디가 이미 있는 경우
                if (clientTable.ContainsValue(userName))
                {
                    clientTable.Remove(id);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //사용자 정보 리스트를 얻기 위한 속성(Property) 정의
        public static Hashtable GetList
        {
            get
            {
                return clientTable;
            }
        }
    }
}

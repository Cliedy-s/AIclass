using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace MyTCPServerProgram
{
    public class MyTCPServer
    {
        Thread serverThread;
        TcpListener llistener = null;
        TcpClient client;
        StreamWriter streamWriter;
        string logFilePath = @"C:\TCPServerLog.txt";

        public MyTCPServer()
        {

            IPEndPoint localaddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5455);
            llistener = new TcpListener(localaddress);
            FileStream file = new FileStream(logFilePath, FileMode.OpenOrCreate);
            file.Close();
        }

        public void Start()
        {
            DateTime now = DateTime.Now;
            writeLog(string.Format("{0} {1} : TCP서버 서비스를 시작합니다", now.ToShortDateString(), now.ToLongTimeString()));
            writeLog(string.Format("{0} {1} : TCP메아리 서버 시작...", now.ToShortDateString(), now.ToLongTimeString()));
            serverThread = new Thread(processServer);
            serverThread.Start();
        }
        public void Stop()
        {
            llistener.Stop();
            serverThread.Abort();
        }
        private void writeLog(string add)
        {
            using (streamWriter = new StreamWriter(logFilePath, true))
            {
                streamWriter.WriteLine(add);
            }
        }

        private void processServer()
        {
            llistener.Start();
            while (true)
            {
                client = llistener.AcceptTcpClient();
                new Thread(() => { processThread(client); }).Start();
            }
        }

        public void processThread(TcpClient client)
        {
            // gci -Recurse "프로젝트가 있는 폴더경로" | Unblock-File  :: https://happytomorrow.net/217 // unblock file해주는 코드 powershell에서 실행
            NetworkStream stream = null;
            IPEndPoint clientAddress = null;
            //try
            //{
            clientAddress = (IPEndPoint)client.Client.RemoteEndPoint;
            writeLog(string.Format("클라이언트 접속 : {0}", clientAddress.ToString()));
            stream = client.GetStream();

            int length;
            string data = null;
            byte[] bytes = new byte[256];
            while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) // get
            {
                data = Encoding.Default.GetString(bytes, 0, length); // byte => string
                writeLog(string.Format("수신: [{1}] {0}", data, clientAddress.Port.ToString()));
                if (data == "bye") break;

                byte[] msg = Encoding.Default.GetBytes(data); // string => byte
                stream.Write(msg, 0, msg.Length);  // send
                Console.WriteLine("송신 :[{1}] {0} :", data, clientAddress.Port.ToString());
                writeLog(string.Format("송신 :[{1}] {0}", data, clientAddress.Port.ToString()));
            }
            //}
            //catch (Exception)
            //{ }
            //finally
            //{
            writeLog(string.Format("클라이언트 종료 : {0}", clientAddress.ToString()));
            stream.Close();
            client.Close();
            writeLog(Thread.CurrentThread.Name);
            Thread.CurrentThread.Abort();
            //}
        }
    }
}

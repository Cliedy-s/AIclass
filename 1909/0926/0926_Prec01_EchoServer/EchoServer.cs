using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace _0926_Prec01_EchoServer
{
    /// <summary>
    /// Step 1. > net stop 서비스명
    /// Step 2. > taskkill / F / IM mmc.exe
    /// Step 3. > sc delete 서비스명
    /// => 서비스 강제로 내리기
    /// </summary>
    public class EchoServer
    {
        Thread serverThread;
        TcpListener llistener = null;
        TcpClient client;
        StreamWriter streamWriter;

        public EchoServer()
        {
            IPEndPoint localaddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5455);
            llistener = new TcpListener(localaddress);
            FileStream file = new FileStream(@"C:\EchoServer.Log", FileMode.OpenOrCreate);
            file.Close();
        }

        public void Start()
        {
            WriteEventLogEntry("메아리 서버 시작...");
            writeLog("시작");
            serverThread = new Thread(processServer);
            serverThread.Start();
        }
        public void Stop()
        {
            WriteEventLogEntry("메아리 서버 중지...");
            writeLog("중지");
            llistener.Stop();
            serverThread.Abort();
        }
        public void logging(object sender, ElapsedEventArgs arg)
        {
            writeLog("실행중");
        }
        private void writeLog(string add)
        {
            using (streamWriter = new StreamWriter(@"C:\EchoServer.Log", true))
            {
                streamWriter.Write("{0} :: 메아리 서버 : {1}\n", DateTime.Now.ToString(), add);
            }
        }

        private void processServer()
        {
            WriteEventLogEntry("메인 스레드 실행...");
            llistener.Start();
            while (true)
            {
                client = llistener.AcceptTcpClient();
                WriteEventLogEntry("고객 접속...");
                new Thread(() => { processThread(client); }).Start();
            }
        }
        /// <summary>
        ///  이벤트 뷰어에 로그 찍는 프로그램, Infomation, eventID = 8
        /// </summary>
        /// <param name="message">출력할 메시지</param>
        private static void WriteEventLogEntry(string message)
        {
            System.Diagnostics.EventLog eventLog = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("EchoServerLog"))
            {
                System.Diagnostics.EventLog.CreateEventSource("EchoServerLog", "EchoServerLogFolder"); //EchoServerLogFolder내 EchoServerLog에 로그가 쌓임
            }
            eventLog.Source = "EchoServerLog";
            int eventID = 8;
            eventLog.WriteEntry(message,
                                System.Diagnostics.EventLogEntryType.Information,
                                eventID);
            eventLog.Close();
        }


        public void processThread(TcpClient client)
        {
            // gci -Recurse "프로젝트가 있는 폴더경로" | Unblock-File  :: https://happytomorrow.net/217 // unblock file해주는 코드 powershell에서 실행
            NetworkStream stream = null;
            try
            {
                Console.WriteLine("클라이언트 접속 : {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());
                stream = client.GetStream();

                int length;
                string data = null;
                byte[] bytes = new byte[256];
                while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) // get
                {
                    data = Encoding.Default.GetString(bytes, 0, length); // byte => string
                    Console.WriteLine("수신 : {0}", data);
                    writeLog("메아리 = " + data);

                    byte[] msg = Encoding.Default.GetBytes(data); // string => byte
                    stream.Write(msg, 0, msg.Length);  // send
                    Console.WriteLine("송신 : {0} :: {1}", data, msg);
                }
            }
            catch (Exception err)
            {
                writeLog(err.Message);
                WriteEventLogEntry(err.ToString());
            }
            finally
            {
                stream.Close();
                client.Close();
                WriteEventLogEntry("고객 접속종료...");
                Thread.CurrentThread.Abort();
            }
        }
    }
}

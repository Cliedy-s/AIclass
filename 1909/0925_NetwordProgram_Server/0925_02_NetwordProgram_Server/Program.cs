using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0925_02_NetwordProgram_Server
{
    public class EchoServer
    {
        static Thread serverThread;
        static TcpListener llistener = null;

        static void Main(string[] args)
        {
            try
            {
                IPEndPoint localaddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5425);
                llistener = new TcpListener(localaddress);
                Console.WriteLine("메아리 서버 시작...");
                llistener.Start();
                serverThread = new Thread(processData);
                serverThread.Start();
            }
            catch
            {

            }

        }
        public void Start()
        {

        }

        public void Stop()
        {
            llistener.Stop();
            serverThread.Abort();
        }

        private static void processData()
        {
            TcpClient client;
            while (true)
            {
                client = llistener.AcceptTcpClient();
                new Thread(()=> processThread(client)).Start();
            }

        }
        public static void processThread(TcpClient client)
        {
            try
            {
                while (true)
                {
                    //Thread t1 = new Thread(processData);
                    //TcpClient client = getClient as TcpClient;
                    Console.WriteLine("클라이언트 접속 : {0}", ((IPEndPoint)client.Client.RemoteEndPoint).ToString());
                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[128];

                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0) // get
                    {
                        data = Encoding.Default.GetString(bytes, 0, length); // byte => string
                        Console.WriteLine("수신 : {0}", data);

                        byte[] msg = Encoding.Default.GetBytes(data); // string => byte
                        stream.Write(msg, 0, msg.Length);  // send
                        Console.WriteLine("송신 : {0} :: {1}", data, msg);
                    }
                    stream.Close();
                    client.Close();
                }
            }
            catch { }
        }
    }
}

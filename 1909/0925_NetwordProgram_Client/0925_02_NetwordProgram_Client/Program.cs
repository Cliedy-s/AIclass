using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _0925_02_NetwordProgram_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int bindPort = Convert.ToInt32(args[0]);
            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5455);

                Console.WriteLine("클라이언트 : {0} , 서버 : {1}", clientAddress.ToString(), serverAddress.ToString());

                TcpClient client = new TcpClient(clientAddress);
                
                client.Connect(serverAddress);
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    Console.WriteLine("메세지 : ");
                    string msg = Console.ReadLine();
                    if (msg == "q") break;
                    byte[] data = Encoding.Default.GetBytes(msg);
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("송신 : {0}", msg);

                    data = new byte[256];
                    string responseData = "";
                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.Default.GetString(data, 0, bytes);
                    Console.WriteLine("수신 : {0}", responseData);
                }
                stream.Close();
                client.Close();

            }
            catch (SocketException err)
            {
                Console.WriteLine(err);
            }
            Console.WriteLine("클라이언트를 종료합니다..");
        }
    }
}

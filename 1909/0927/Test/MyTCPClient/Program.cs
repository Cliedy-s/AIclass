using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Web.Services.Description;
using System.Net.NetworkInformation;

namespace MyTCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            NetworkStream stream = null;
            int bindPort = Convert.ToInt32(args[0]);
            //IPGlobalProperties.GetIPGlobalProperties

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5455);

                Console.WriteLine("클라이언트 : {0} , 서버 : {1}", clientAddress.ToString(), serverAddress.ToString());
                Console.WriteLine("종료는 'bye' 입력을 해주세요");

                client = new TcpClient(clientAddress);

                client.Connect(serverAddress);
                stream = client.GetStream();

                while (true)
                {
                    Console.Write("메세지 : ");
                    string msg = Console.ReadLine();
                    byte[] data = Encoding.Default.GetBytes(msg);
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("송신 : [{1}] {0}", msg, clientAddress.Port);
                    if (msg == "bye")
                    {
                        break;
                    }

                    data = new byte[256];
                    string responseData = "";
                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.Default.GetString(data, 0, bytes);
                    Console.WriteLine("수신 : [{1}] {0}", responseData, clientAddress.Port);
                }
            }
            catch (SocketException err)
            {
                Console.WriteLine(err);
            }
            finally
            {
                stream.Close();
                client.Close();
                Console.WriteLine("클라이언트를 종료합니다..");
            }
        }
    }
}

using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _0203_02_WorkerClient
{
    class Program
    {
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("WorkerClient", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility;  } }

        static int machineID = 1;
        static Timer timer;
        static void Main(string[] args)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            machineID = rand.Next(0, 9);

            Console.WriteLine("생산량 전송 프로그램 시작");
            SetTimer();
            Console.ReadLine();
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("생산량 전송 프로그램 종료");
        }

        private static void SetTimer()
        {
            timer = new Timer(3000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true; // 타이머 시작
            timer.AutoReset = true;
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rand = new Random((int)DateTime.UtcNow.Ticks);

            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            NetworkStream stream = tc.GetStream();

            string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/MachineID/{machineID}/{rand.Next(1, 77)}/{rand.Next(1, 5)}/{rand.Next(0, 1)}";
            byte[] buff = Encoding.ASCII.GetBytes(msg);
            stream.Write(buff, 0, buff.Length);

            byte[] outbuff = new byte[1024];
            int nbytes = stream.Read(outbuff, 0, outbuff.Length);
            string outMsg = Encoding.ASCII.GetString(outbuff, 0, outbuff.Length);
            stream.Close();
            tc.Close();
            Console.WriteLine($"{nbytes} bytes : {outMsg}");
            Log.WriteInfo($"{nbytes} bytes : {outMsg}");
        }
    }
}

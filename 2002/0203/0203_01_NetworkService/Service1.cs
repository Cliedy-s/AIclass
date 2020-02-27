using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0203_01_NetworkService
{
    public partial class Service1 : ServiceBase
    {
        string strConn = "Server=192.168.0.5;uid=sa;pwd=1234;database=WorkDB";
        public Service1()
        {
            InitializeComponent();
        }

        //protected override void OnStart(string[] args)
        //{
        //}

        public void OnStart()
        {
            AsyncEchoServer().Wait();
        }

        async Task<TcpClient> AsyncEchoServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
            listener.Start();
            while (true)
            {
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false); // client도 .Net기반일 때 ConfigureAwait(false)
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }
        private async void AsyncTcpProcess(object o)
        {
            TcpClient tc = o as TcpClient;
            NetworkStream stream = tc.GetStream();
            byte[] buff = new byte[1024];

            var readTask = stream.ReadAsync(buff, 0, buff.Length);
            var timeouttask = Task.Delay(10 * 1000); // 10초 기다리는 스레드 풀

            var doneTask = await Task.WhenAny(readTask, timeouttask);
            if(doneTask == timeouttask)
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Read Timeout");
                Program.Log.WriteError("Read TimeOut");
                await stream.WriteAsync(bytes, 0, bytes.Length);
                return;
            }

            int nbytes = readTask.Result;
            if(nbytes > 0)
            {
                string msg = Encoding.ASCII.GetString(buff, 0, nbytes);
                string[] arrdata = msg.Split('/');

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(strConn);
                    comm.CommandText = "INSERT INTO WorkQtyLog (ProductID, MachineID, Qty, BadQty) VALUES(@ProductID, @MachineID, @Qty, @BadQty); ";
                    comm.Parameters.AddWithValue("@ProductID", int.Parse(arrdata[3]));
                    comm.Parameters.AddWithValue("@MachineID", int.Parse(arrdata[2]));
                    comm.Parameters.AddWithValue("@Qty", int.Parse(arrdata[4]));
                    comm.Parameters.AddWithValue("@BadQty", int.Parse(arrdata[5]));

                    comm.Connection.Open();
                    comm.ExecuteNonQuery();
                    comm.Connection.Close();
                }

                Console.WriteLine(msg);
                Program.Log.WriteInfo(msg);

                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
            }

            stream.Close();
            tc.Close();
        }

        protected override void OnStop()
        {
            
        }
    }
}

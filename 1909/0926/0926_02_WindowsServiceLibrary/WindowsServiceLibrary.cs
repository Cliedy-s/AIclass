using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _0926_02_WindowsServiceLibrary
{
    public class WindowsServiceLibrary
    {
        StreamWriter sw;
        string fileName = @"C:\_0926_02_WindowsServiceLibrary.log";
        string curTime = string.Empty;
        Thread serverThread;

        public WindowsServiceLibrary()
        {
            serverThread = new Thread(() => { ServiceLoop(); });
            sw = new StreamWriter(fileName, true, Encoding.UTF8);
        }

        public void Start()
        {
            serverThread.Start();
            curTime = DateTime.Now.ToString();
            sw.WriteLine(curTime + "Start Service");
            sw.Flush(); // 클로즈시 버퍼에 있는걸 보내줌

        }
        public void Stop()
        {
            serverThread.Abort();
            curTime = DateTime.Now.ToString();
            sw.WriteLine(curTime + "Stop Service");
            sw.Close();
        }

        private void ServiceLoop()
        {
            while (true)
            {
                curTime = DateTime.Now.ToString();
                sw.WriteLine("{0} : {1} ", curTime, "Running Service");
                sw.Flush();
                Thread.Sleep(1000);
            }
        }
    }
}

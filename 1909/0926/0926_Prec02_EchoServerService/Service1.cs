using _0926_Prec01_EchoServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _0926_Prec02_EchoServerService
{
    public partial class Alambana_EchoServer : ServiceBase
    {
        EchoServer echoserver;
        private Timer timer;

        public Alambana_EchoServer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            echoserver = new EchoServer();
            echoserver.Start();
            timer = new Timer();
            timer.Interval = 3000; // 3초마다 실행
            timer.Elapsed += echoserver.logging;
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
            echoserver.Stop();
        }
    }
}

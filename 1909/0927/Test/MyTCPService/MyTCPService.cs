using MyTCPServerProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyTCPService
{
    public partial class MyTCPService : ServiceBase
    {
        MyTCPServer myTCPServer;
        public MyTCPService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            myTCPServer = new MyTCPServer();
            myTCPServer.Start();
        }

        protected override void OnStop()
        {
            myTCPServer.Stop();
        }
    }
}

using _0926_02_WindowsServiceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace _0926_01_WindowsService
{
    public partial class _092601WindowsService : ServiceBase
    {
        WindowsServiceLibrary windowsService;

        public _092601WindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            windowsService = new WindowsServiceLibrary();
            windowsService.Start();
        }

        protected override void OnStop()
        {
            windowsService.Stop();
        }
    }
}

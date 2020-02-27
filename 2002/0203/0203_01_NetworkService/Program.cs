using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace _0203_01_NetworkService
{
    static class Program
    {
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("WorkerClient", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new Service1()
            //};
            //ServiceBase.Run(ServicesToRun);
            Service1 service = new Service1();
            service.OnStart();
        }
    }
}

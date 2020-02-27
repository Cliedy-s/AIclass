using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _0131_01_WorkLog
{
    class Program
    {
        static Timer timer;
        static string writefolder = ConfigurationManager.AppSettings["WriteFolder"];
        static int interval = int.Parse(ConfigurationManager.AppSettings["LogCreateMillisecond"]);
        static string machineID = ConfigurationManager.AppSettings["MachineID"];
        static int iCnt = 0;

        static void Main(string[] args)
        {
            //new StreamWriter("", true, new UTF8Encoding(false));
            Console.WriteLine("생산량 파일 로그 기록 시작...");
            SetTimer();

            Console.ReadKey();
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("생산량 파일 로그 기록 종료...");
        }
        private static void SetTimer()
        {
            timer = new Timer(interval);
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            //timer.Start();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter($"{writefolder}\\WorkerLogMachine_{machineID}_{iCnt}.log", false);
                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}/Machine/{machineID}/{rnd.Next(1, 77)}/{rnd.Next(100, 130)}/{rnd.Next(0, 2)}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                iCnt++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0131_02_WorkLogService
{
    public static class WorkerLoger
    {
        public static void WriteLog(string msg)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                WriteErrorLog(ee);
            }
        }
        public static void WriteErrorLog(string errmsg)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine($"{DateTime.Now.ToString()} [ERROR] : {errmsg}");
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                WriteErrorLog(ee);
            }
        }
        public static void WriteErrorLog(Exception err)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine($"{DateTime.Now.ToString()} [ERROR] : {err.Message}");
                sw.Flush();
                sw.Close();
            }
            catch (Exception ee)
            {
                
            }
        }
    }
}

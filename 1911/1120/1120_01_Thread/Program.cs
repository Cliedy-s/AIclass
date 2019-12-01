using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1120_01_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread);

            Process proc = Process.GetCurrentProcess();

            ProcessThreadCollection ptc = proc.Threads;
            Console.WriteLine("현재 프로세스에서 실행중인 스레드 수 : {0} ", ptc.Count);

            ThreadInfo(ptc);
        }

        static void ThreadInfo(ProcessThreadCollection ptc) {
            int i = 1;
            foreach (ProcessThread pt in ptc)
            {
                Console.WriteLine("============{0}번째 스레드==========", i++);
                Console.WriteLine("ThreadID : {0}", pt.Id);
                Console.WriteLine("시작시간 : {0}", pt.StartTime);
                Console.WriteLine("우선순위: {0}", pt.BasePriority);
                Console.WriteLine("상태 : {0}", pt.ThreadState);
                Console.WriteLine();
            }
        }
    }
}

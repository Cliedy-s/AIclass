using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1120_02_MainThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("메인 스레드 정보 출력");
            Console.WriteLine("Thread.{0,-19} : {1}", "ID", thread.GetHashCode());
            Console.WriteLine("Thread.{0,-19} : {1}", "Name", thread.Name);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsAlive", thread.IsAlive);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsBackground", thread.IsBackground);
            Console.WriteLine("Thread.{0,-19} : {1}", "Priority", thread.Priority);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentCulture", thread.CurrentCulture);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentUICulture", thread.CurrentUICulture);

            Thread subThread = new Thread(ThreadMethod);
            //subThread.Start();

            Thread subThread2 = new Thread(ParameterizedThreadMethod); // 컴파일러가 Thread 델리게이트를 추론해야하기 때문에 비추
            Thread subThread2_5 = new Thread(new ParameterizedThreadStart(ParameterizedThreadMethod));
            // subThread2.Start(thread.GetHashCode());

            Thread subThread3 = new Thread(() => { oddThreadMethod(thread.GetHashCode()); });
            //subThread3.Start();

            Thread subThread4 = new Thread(() => Wait());
            subThread4.IsBackground = true; // 메인 스레드 종료시 스레드도 종료시킨다.
            // <=> false : 메인 스레드가 종료되어도 서브가 계속 돌아감
            subThread4.Start();
            Console.WriteLine("스레드 기다리기");

            Thread subThread5 = new Thread(new ParameterizedThreadStart(ParamSum));
             subThread5.Start(new MyParam { fromval = 0, toval = 100});


        }
        class MyParam
        {
            public int fromval;
            public int toval;
        }

        static void ThreadMethod()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("서브 스레드 정보 출력");
            Console.WriteLine("Thread.{0,-19} : {1}", "ID", thread.GetHashCode());
            Console.WriteLine("Thread.{0,-19} : {1}", "Name", thread.Name);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsAlive", thread.IsAlive);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsBackground", thread.IsBackground);
            Console.WriteLine("Thread.{0,-19} : {1}", "Priority", thread.Priority);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentCulture", thread.CurrentCulture);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentUICulture", thread.CurrentUICulture);
        }
        static void ParameterizedThreadMethod(object mainID)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("{0}의 서브 스레드 정보 출력", Convert.ToInt32(mainID));
            Console.WriteLine("Thread.{0,-19} : {1}", "ID", thread.GetHashCode());
            Console.WriteLine("Thread.{0,-19} : {1}", "Name", thread.Name);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsAlive", thread.IsAlive);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsBackground", thread.IsBackground);
            Console.WriteLine("Thread.{0,-19} : {1}", "Priority", thread.Priority);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentCulture", thread.CurrentCulture);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentUICulture", thread.CurrentUICulture);
        }
        static void ParamSum(object sums) {
            MyParam mpa = sums as MyParam;
            int min = mpa.fromval;
            int max = mpa.toval;
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }
            Console.WriteLine("값 : " + sum);
        }
        static void oddThreadMethod(int mainID)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("{0}의 서브 스레드 정보 출력", mainID);
            Console.WriteLine("Thread.{0,-19} : {1}", "ID", thread.GetHashCode());
            Console.WriteLine("Thread.{0,-19} : {1}", "Name", thread.Name);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsAlive", thread.IsAlive);
            Console.WriteLine("Thread.{0,-19} : {1}", "IsBackground", thread.IsBackground);
            Console.WriteLine("Thread.{0,-19} : {1}", "Priority", thread.Priority);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentCulture", thread.CurrentCulture);
            Console.WriteLine("Thread.{0,-19} : {1}", "CurrentUICulture", thread.CurrentUICulture);
        }
        static void Wait()
        {
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000 * 60);
            Console.WriteLine("스레드 종료");
        }
        
    }
}

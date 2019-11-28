using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1121_02_Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스레드
            // --동기 호출
            Console.WriteLine(ParamSum(new MyParam() { fromval = 0, toval = 10 }));
            // ----동기지만 비동기처럼 사용 ( 스레드 )
            Thread thread = new Thread(Run);
            thread.Start(null);

            // ------ 스레드풀 방법
            ThreadPool.QueueUserWorkItem(Run); // ParameterizedThreadStart == WaitCallback

            Task t2 = new Task(Run, null);
            t2.Start();

            // --비동기 호출
            // ----리턴x
            Task.Factory.StartNew(Run, null);

            // ----리턴o
            // ------ 테스크로
            Task<int> task = Task.Factory.StartNew(ParamSum, new MyParam { fromval = 50, toval = 100 }); // 스레드 풀에서 스레드를 비동기로 호출함
            Console.WriteLine(task.Result); // 결과가 나올 때까지 기다림..

            int result = (Task.Factory.StartNew(ParamSum, new MyParam { fromval = 50, toval = 100 })).Result; // 시작과 동시에 결과가 나올 때까지 기다림
            Console.WriteLine(result);

            // ------ 델리게이트로
            Func<object, int> work = ParamSum;
            IAsyncResult asyncResult = work.BeginInvoke(new MyParam() { fromval = 0, toval = 10 }, null, null);
            Console.WriteLine("작업...");
            int result2 = work.EndInvoke(asyncResult);
            Console.WriteLine("Result : {0}", result2);
            //


            Console.WriteLine("Hello");
            Console.ReadLine();
        }
        class MyParam
        {
            public int fromval;
            public int toval;
        }
        static int ParamSum(object sums)
        {
            MyParam mpa = sums as MyParam;
            int min = mpa.fromval;
            int max = mpa.toval;
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Run(object args)
        {
            Console.WriteLine("60초 후에 프로그램 종료");
            Thread.Sleep(1000 * 60);
            Console.WriteLine("스레드 종료!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1121_01_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ParamSum);
            MyParam param = new MyParam { fromval = 0, toval = 100 };
            t1.Start(param);

            Console.WriteLine("쓰레드 생성");
            ThreadPool.QueueUserWorkItem(ParamSum, new MyParam { fromval = 50, toval = 100 }); // Foreground
            Console.WriteLine("쓰레드 풀에서 작업");
        }
        static void ParamSum(object sums)
        {
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
        class MyParam
        {
            public int fromval;
            public int toval;
        }

    }
}

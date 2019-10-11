using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
   public  class Calculator
    {
        public int Sum(params int[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                //if (i < 0)
                //{ 
                //    Console.Write("0 보다 큰 수 입력");
                //    continue;
                // }

                sum += args[i];

            }
            //Console.WriteLine();
            return sum;
        }

        public int SumAll(int end)
        {
            return SumAll(0, end);
        }

        public int SumAll(int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_01_MyCalculator
{
    public class Calculator
    {
        public int Sum(params int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            return sum;
        }
        public int SumNoParams(int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            return sum;
        }
        /*
                // 음수~ 양수 계산 ㅇ
                public int SumAll(int first, int last=0)
                {
                    int sum = 0;
                    if (last == 0 && first >= 0)
                    {
                        last = first;
                        first = 0;
                    }
                    for (int i = first; i <= last; i++)
                    {
                        sum += i;
                    }
                    return sum;
                }
        */

        // 깔끔한 방법
        public int SumAll(int last)
        {
            return SumAll(0, last); // 함수 호출
        }
        public int SumAll(int first, int last)
        {
            int sum = 0;
            for (int i = first; i <= last; i++)
            {
                sum += i;
            }
            return sum;
        }
        //
    }
}

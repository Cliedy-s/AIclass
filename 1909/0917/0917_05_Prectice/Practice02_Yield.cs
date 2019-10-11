using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0917_05_Practice
{
    class Practice02_Yield
    { // IEnumerable에 관한 것은 0910에 존재
        static void Main(string[] args)
        {
            /*
                        foreach (int n in YieldNaturalNumber.Next())
                        {
                            Console.WriteLine(n); // 무한대만큼 출력
                        }
            */
            foreach (int n in YieldNaturalNumber.Next(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine(n);
            }

        }
    }
    class YieldNaturalNumber
    {
        public static IEnumerable<int> Next()
        {
            int _start = 0;
            while (true)
            {
                yield return _start; // return을 무한대로 하게됨
            }
        }

        public static IEnumerable<int> Next(int i)
        {
            for (; i < 10;)
            {
                yield return i++;
            }
        }
    }
}

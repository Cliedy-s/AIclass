using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_03_입력받기
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력받기
            Console.WriteLine("당신의 나이는? ");
            string sAge = Console.ReadLine(); // enter를 기다리는 함수

            int iAge = int.Parse(sAge);
            Console.WriteLine("내년은 {0}살입니다.", iAge + 1);
            string result = iAge.ToString();
            Console.WriteLine("10년 후의 나이는 {0}세 입니다.", iAge + 10);

            // 
            System.Convert.ToInt32(sAge); // conver class => 어떠한 타입이든 가능
            Int32.Parse(sAge); // 문자열 o
            int.Parse(sAge);
            //
            System.Convert.ToString(sAge);
            sAge.ToString(); // object의 함수
                             //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0113_01_몸풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 2;
            //for (int i = 3; i < 1000; i++)
            //{
            //    if (IsPrimary(i)) sum += i;
            //}
            //Console.WriteLine("1에서 1000까지의 소수의 합 : {0}", sum);
            try
            {
                TryCatchTest();
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.Message); 
            }
            Console.WriteLine("종료..");
        }
        static void TryCatchTest()
        {
            try {
                Console.WriteLine("Try 실행");
                //return;
                throw new Exception("try 오류발생");
            }
            catch (Exception ee)
            {
                Console.WriteLine("Catch 실행");
                throw new Exception("catch 오류발생");
            }
            finally
            {
                Console.WriteLine("Finally 실행");
                throw new Exception("finally 오류발생");
            }
        }

        static bool IsPrimary(int i)
        {
            if (i % 2 == 0) return false;
            for (int j = 3; j*j <= i; j++)
            {
                if (i % j == 0) return false;
            }
            return true;
        }
    }
}

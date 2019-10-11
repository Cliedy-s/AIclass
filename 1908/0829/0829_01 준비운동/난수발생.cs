using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0829_01_준비운동
{
    class 난수발생
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num1 = 0, num2 = 0;
            while (true)
            {
                num1 = rand.Next(10);
                num2 = rand.Next(10);
                Console.WriteLine("{0} + {1} = ? ", num1, num2);
                Console.Write(" :: ");

                if ((num1 + num2) == int.Parse(Console.ReadLine()))
                    Console.WriteLine("정답입니다. ");
                else
                    Console.WriteLine("틀렸습니다. 답 : {0} ", num1 + num2);

                Console.Write("다시 하시겠습니까?(y/n) ");
                if (Console.ReadLine().ToUpper() != "Y")
                    break;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0829
{
    class simpleAddCalc
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();
                int num1 = rand.Next(10);  //0~n-1 사이의 값을 반환 Next(10, 100)
                int num2 = rand.Next(10);  //0~n-1 사이의 값을 반환

                Console.WriteLine("{0} + {1} = ?", num1, num2);
                int answer = int.Parse(Console.ReadLine());

                if (answer == (num1 + num2))
                {
                    Console.WriteLine("정답입니다!");
                }
                else
                {
                    Console.WriteLine("오답입니다ㅠㅠㅠ.  정답은 {0} 입니다.", num1 + num2);
                }

                Console.Write("계속하시겠습니까?(y/n) :");
                if (Console.ReadLine().ToUpper() == "N")
                    break;
            }
        }
    }
}

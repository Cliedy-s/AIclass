using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_04_주말숙제
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            Random rand = new Random();

            int num1 = 0, num2 = 0, result = 0, cnt = 0, op = 0;
            string level = string.Empty;

            while (true)
            {
                SelectLevel(out level);
                RandomValues(level, out num1, out num2);
                if (num1 == -1)
                {
                    Console.WriteLine("다시 입력해주세요");
                    continue;
                }

                for (int i = 1; i < 6; i++)
                {
                    op = rand.Next(0, 4);
                    RandomValues(level, out num1, out num2);
                    OpAndResult(num1, num2, op, out result);
                    Console.Write("{3}번 문제 : {0} {1} {2} = ", num1, op, num2, i);
                    if (result == int.Parse(Console.ReadLine()))
                    {
                        cnt++;
                        Console.WriteLine("정답입니다.");
                    }
                    else
                        Console.WriteLine("틀렸습니다.");
                }
                //
                Console.WriteLine("정답률 : {0}%", cnt / 5.0 * 100);
                if (cnt / 5.0 * 100 >= 80)
                {
                    Console.Write("다시 하시겠습니까?(Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") break;
                    SelectLevel(out level);
                }
                //
            }
        } //Main

        //
        static void SelectLevel(out string level)
        {
            Console.Write("난이도를 무엇으로 하시겠습니까? (상/중/하) :: ");
            level = Console.ReadLine();
        }  //SelectLevel

        static void RandomValues(string level, out int num1, out int num2)
        {
            Random rand = new Random();
            num1 = 0;
            num2 = 0;

            switch (level)
            {
                case "상":
                    num1 = rand.Next(100, 1000);
                    num2 = rand.Next(100, 1000);
                    break;
                case "중":
                    num1 = rand.Next(10, 100);
                    num2 = rand.Next(10, 100);
                    break;
                case "하":
                    num1 = rand.Next(0, 10);
                    num2 = rand.Next(0, 10);
                    break;
                default:
                    num1 = -1;
                    break;
            }
        } // RandomValues

        static void OpAndResult(int num1, int num2, int op, out int result)
        {
            Random rand = new Random();
            Calculator cal = new Calculator();
            result = 0;
            switch (op)
            {
                case 0:
                    result = cal.Plus(num1, num2);
                    break;
                case 1:
                    result = cal.Minus(num1, num2);
                    break;
                case 2:
                    result = cal.Multiple(num1, num2);
                    break;
                case 3:
                    result = cal.Divide(num1, num2);
                    break;
            }
        }// OpAndResult
    }
}

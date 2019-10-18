using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0829
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = string.Empty;

            //do
            //{
            //    Console.Write("반복 횟수를 입력하세요.");
            //    int cnt = int.Parse(Console.ReadLine());

            //    if (cnt <= 0)
            //    {
            //        Console.WriteLine("0보다 작거나 같은 수는 입력 할 수 없습니다.");
            //        continue;
            //    }

            //    for (int i = 0; i < cnt; i++)
            //    {
            //        for (int j = 0; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine("");
            //    }

            //    Console.Write("계속하시겠습니까?(y/n) :");
            //    str = Console.ReadLine();

            //} while (str.ToUpper() == "Y");


            while (true)
            {
                Console.Write("반복 횟수를 입력하세요.");
                int cnt = int.Parse(Console.ReadLine());

                if (cnt <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력 할 수 없습니다.");
                    continue;
                }

                for (int i = 0; i < cnt; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                Console.Write("계속하시겠습니까?(y/n) :");
                string str = Console.ReadLine();

                if (str.ToUpper() == "N")
                    break;

                //if (str == "n" || str == "N")
                //    break;

            }
        }
    }
}

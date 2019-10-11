using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0829_01_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            /*
                        while (true)
                        {
                            Console.Write("반복 횟수를 입력하세요. : ");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                for (int j = 0; j < i + 1; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.Write("계속하시겠습니까?(y/n) : ");
                            if (Console.ReadLine() != "y")
                                break;
                        }
            */
            // 

            // do while
            try
            {
                do
                {
                    Console.Write("반복 횟수를 입력하세요. : ");
                    int count = int.Parse(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("0보다 작거나 같은 수는 입력 할 수 없습니다.");
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < i + 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.Write("계속하시겠습니까? (y/n) : ");
                } while (Console.ReadLine().ToUpper() == "Y");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            //
        }

    }
}

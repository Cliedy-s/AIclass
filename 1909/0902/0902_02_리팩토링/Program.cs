using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902_02_리팩토링
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리팩토링 => 선택 +우측클릭 => 리팩토링 :: 메소드 추출
            Random rand = new Random();
            int Num = 0, answer = 0, maxplaycount = 0;

            maxplaycount = 6;
            while (true)
            {
                Num = rand.Next(1, 21);
                for (int i = 1; i < maxplaycount + 1; i++)
                {
                    WriteLine1To20();
                    answer = int.Parse(Console.ReadLine());
                    if (Num > answer)
                        Console.WriteLine("Up");
                    else if (Num < answer)
                        Console.WriteLine("Down!");
                    else
                    {
                        Console.WriteLine("성공! {0}번 만에 맞추셨습니다!!", i);
                        break;
                    }
                }
                if (Num != answer)
                    Console.WriteLine("실패하셨습니다.");
                Console.Write("계속하시겠습니까?(Y/N) :: ");
                if (Console.ReadLine().ToUpper() != "Y")
                    break;
            }
        }

        private static void WriteLine1To20()
        {
            Console.WriteLine("1부터 20까지의 숫자를 입력하세요.");
        }
    }
}

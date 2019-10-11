using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0911_01_준비운동_가위바위보
{
    class Program
    {
        enum rockPaperScissor { 가위 = 1, 바위, 보 }
        static void Main(string[] args)
        {
            int userRockPaperScissor = 1, comRockPaperScissor = 1;
            double winCount = 0, totalCount = 0;
            Random rand = new Random();

            Console.WriteLine(System.DateTime.Now.ToShortDateString()); // format : yyyy-mm-dd (ToShortDateString()), 
            while (true)
            {
                Console.WriteLine("1. 가위, 2. 바위, 3. 보");
                Console.Write("선택 : ");

                /*
                 // 예전 방법
                                try
                                {
                                    userRockPaperScissor = int.Parse(Console.ReadLine());
                                    comRockPaperScissor = rand.Next(1, 4);
                                    if (userRockPaperScissor < 1 || userRockPaperScissor > 3) throw new Exception("1부터 3까지만 입력해 주세요");
                                }
                                catch(FormatException)
                                {
                                    Console.WriteLine("문자를 입력하지 마세요.");
                                    continue;   
                                }
                                catch (Exception err)
                                {
                                    Console.WriteLine("{0} 다시 입력해주세요", err.Message);
                                    continue;
                                }
                */
                bool isSuccess= int.TryParse(Console.ReadLine(), out userRockPaperScissor);
                if (!isSuccess)
                {
                    Console.WriteLine("1부터 3까지만 입력해 주세요.");
                    continue;
                }
                comRockPaperScissor = rand.Next(1, 4);
                Console.WriteLine("나) {0} : {1} (컴", RockPaperScissorToString(userRockPaperScissor), RockPaperScissorToString(comRockPaperScissor));
                Console.Write("결과 : ");

                switch (compareRockPaperScissor(userRockPaperScissor, comRockPaperScissor))
                {
                    case -1:
                        Console.WriteLine("졌습니다.");
                        totalCount++;
                        break;
                    case 0:
                        Console.WriteLine("비겼습니다.");
                        break;
                    case 1:
                        Console.WriteLine("이겼습니다.");
                        totalCount++;
                        winCount++;
                        break;
                }
                Console.WriteLine("승률 : {0:F2}%", winCount / totalCount * 100.0, 1); // {0:F2} || Math.Round( ,1)
                Console.Write("계속하시겠습니까? ( Y/ N ) ");
                if (Console.ReadLine().Trim().ToLower() != "y") break; ;
            }
        }


        // 시도 1
        /// <summary>
        /// 가위바위보를 해서 user가 이겼으면 1, 지면 -1, 비기면 0
        /// </summary>
        /// <param name="userRockPaperScissor">가위 1, 바위 2, 보 3</param>
        /// <param name="comRockPaperScissor">가위 1, 바위 2, 보 3</param>
        /// <returns></returns>
        static public int compareRockPaperScissor(int userRockPaperScissor, int comRockPaperScissor)
        {
            /*
                        if (userRockPaperScissor == 1)
                        {
                            if (comRockPaperScissor == 1) return 0;
                            else if (comRockPaperScissor == 2) return -1;
                            else return 1;
                        }
                        else if (userRockPaperScissor == 2)
                        {
                            if (comRockPaperScissor == 1) return 1;
                            else if (comRockPaperScissor == 2) return 0;
                            else return -1;
                        }
                        else 
                        {
                            if (comRockPaperScissor == 1) return -1;
                            else if (comRockPaperScissor == 2) return 1;
                            else return 0;
                        }
            */
            // 선생님
            if (userRockPaperScissor == comRockPaperScissor) return 0;
            else if ((userRockPaperScissor == 1 && comRockPaperScissor == 3)
                || (userRockPaperScissor == 2 && comRockPaperScissor == 1)
                || (userRockPaperScissor == 3 && comRockPaperScissor == 2)) return 1;
            else return -1;
        }
        /// <summary>
        /// 가위바위보에서 문자열로 변환하는 메소드 1:가위, 2:바위, 3:보
        /// </summary>
        /// <param name="rockPaperScissor">1:가위, 2:바위, 3:보</param>
        /// <returns>"가위" or "바위" or "보" or "잘못된 값입니다."</returns>
        static public string RockPaperScissorToString(int rockPaperScissor)
        {
            switch (rockPaperScissor)
            {
                case 1:
                    return "가위";
                case 2:
                    return "바위";
                case 3:
                    return "보";
            }
            return "잘못된 값 입니다.";
        }
        /*
                // 시도 2
                static public int compareRockPaperScissor2(int userRockPaperScissor, int comRockPaperScissor)
                {

                }
        */
    }
}

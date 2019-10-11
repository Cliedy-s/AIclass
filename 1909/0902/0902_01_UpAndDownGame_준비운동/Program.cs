using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902_01_UpAndDownGame_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             // 하나의 메인에 다 쓰기
                        Random rand = new Random();
                        int Num = 0, answer = 0, maxplaycount = 0;

                        maxplaycount = 6;
                        while (true)
                        {
                            Num = rand.Next(1, 21);
                            for (int i = 1; i < maxplaycount + 1; i++)
                            {
                                Console.WriteLine("1부터 20까지의 숫자를 입력하세요.");
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
            */
            // 클래스 나누기

            // orgNum private로 두기
            // 1. 생성자의 파라미터로 멤버변수의 초기값을 넘겨서 객체를 생성한다.
            // 2. 멤버변수에 값을 넘겨주는 메서드를 생성한다.
            // 3. 프로퍼티(속성)을 생성한다.
            // 추천 : 1로 초기값을 넘겨주고 3을 코딩해두어서 언제든 바꿀 수 있도록 한다.

            Random rand = new Random();
            /*
                        // (1)
                        UpDown game = new UpDown(rand.Next(1,21)); 
            */
            /*
                        // (2)
                        UpDown game = new UpDown();
                        game.SetOrgNum(rand.Next(1, 21));
                        //
            */
            // (3)
            UpDown game = new UpDown();
            game.OrgNum = rand.Next(1, 21);
            //

            int guess = 0;
            string result = string.Empty;

            while (true)
            {
                int i = 0;
                for (i = 1; i < 6 + 1; i++)
                {
                    Console.WriteLine("1부터 20까지의 숫자를 입력하세요.");
                    guess = int.Parse(Console.ReadLine());
                    result = game.CheckUpDown(guess);
                    if (result == "성공!")
                        break;
                    else
                        Console.WriteLine("{0}!", result);
                }
                if (game.OrgNum == guess) // (1) : public orgNum, (2) game.GetOrgNum, (3) game.OrgNum
                    Console.WriteLine("맞추셨습니다. {0}만에 맞추셨습니다.", i);
                else if (game.OrgNum != guess) // 
                    Console.WriteLine("실패하셨습니다. 답은 {0} 입니다.", game.OrgNum); //

                Console.Write("계속하시겠습니까?(Y/N) :: ");
                if (Console.ReadLine().ToUpper() != "Y")
                    break;
            }
        }

    }
    public class UpDown
    {
        Random rand = new Random();
        int orgNum;

        /*
                // orgNum private로 두기 (1)
                public UpDown(int orgNum) // (1) : 생성자로 초기값 넘겨주기
                {
                    this.orgNum = orgNum;
                }
                //
        */
        public string CheckUpDown(int inputNum)
        {
            if (orgNum > inputNum)
                return "Up";
            else if (orgNum < inputNum)
                return "Down!";
            else
                return "성공!";
        }

        /*
                // orgNum private로 두기 (2) 
                public void SetOrgNum(int orgNum) // (2) : 멤버변수에 값을 넘겨주는 멤버변수 생성
                {
                    this.orgNum = orgNum;
                }
                public int GetOrgNum()
                {
                    return orgNum;
                }
                //
        */
        /*
                // return 활용 ::  메소드 중지 p103
                public void SetOrgNum(int orgNum) 
                {
                    if (orgNum > 20)
                    {
                        return;
                    }
                    this.orgNum = orgNum;
                }
        */
        // orgNum private로 두기 (3) 
        public int OrgNum
        {
            get
            { return orgNum; }
            set
            { this.orgNum = value; } // OrgNum = 3 -> 3:: value
        }
        //

    }
    //
}

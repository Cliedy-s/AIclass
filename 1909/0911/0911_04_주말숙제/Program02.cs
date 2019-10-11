using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0911_04_주말숙제
{
    class Program02
    {
        static void Main(string[] args)
        {
            // int arrLength =3; // arrLength자리 숫자의 야구게임
            string inputNumbers = string.Empty;
            int totalTry, totalWin;
            totalTry = totalWin = 0;

            RandomNumberGame rng = new RandomNumberGame(); // 랜덤게임 객체
            Console.WriteLine("야구게임입니다. 0~9의 숫자를 맞춰주세요!");
            rng.SetLevel();
            Console.WriteLine("최대시도횟수 {0}, {1}개의 숫자를 입력하세요", rng.MaxCount, rng.ArrLength);
            rng.MakeRandomNumbers(); // rng.arrLength 사이즈의 배열 생성

            // 숫자 야구 게임
            while (true) // 전체 게임 => 승률계산
            {
                totalTry++; // 승률계산을 위한 전체횟수
                while (true)
                {
                    Console.Write("{0}개 숫자 입력 : ", rng.ArrLength);
                    try
                    {
                        inputNumbers = Console.ReadLine().Trim();
                        rng.CheckInputNumbers(inputNumbers); // 해당 값이 올바른 입력인지 확인
                    }
                    catch (Exception err) // throw 처리 메소드에서 throw를 보내줌
                    {
                        MessageBox.Show(err.Message);
                        continue;
                    }
                    rng.CheckStrikesAndBalls(inputNumbers);
                    Console.WriteLine("({2}/{3})==> {0}스트라이크 {1}볼", rng.Strikes, rng.Balls, rng.Count, rng.MaxCount);

                    if (rng.Strikes == rng.ArrLength)
                    {
                        totalWin++; // 승률계산 이긴횟수
                        Console.WriteLine("정답입니다!!");
                        Console.WriteLine("{0}번만에 정답을 맞추셨습니다!", rng.Count); // 시도횟수
                        break;
                    }
                    else if (rng.Count >= rng.MaxCount)
                    {
                        Console.WriteLine("패배하셨습니다.");
                        break;
                    }
                    rng.Count++; // 시도 횟수
                }
                Console.WriteLine("승률 : {0:F2}%", (totalWin / (totalTry * 1.0)) * 100.0);
                Console.WriteLine("계속하시겠습니까? 1.계속 2.종료");
                if (Console.ReadLine().Trim() == "1") rng.ResetGame(); // 계속 할 경우 리셋, 배열도 새로 입력함
                else break;
            }
        }
    }

    /// <summary>
    /// 랜덤게임 클래스
    /// </summary>
    class RandomNumberGame
    {
        Random rand = new Random();
        char[] randomArray = null;
        int strikes = 0, balls = 0, count = 1, arrLength = 0, maxCount = 0;
        #region 프로퍼티들
        public int Strikes { get => strikes; set => strikes = value; }
        public int Balls { get => balls; set => balls = value; }
        public int Count { get => count; set => count = value; }
        public int MaxCount { get => maxCount; set => maxCount = value; }
        public int ArrLength { get => arrLength; set => arrLength = value; }
        #endregion

        public RandomNumberGame() { }
        /// <summary>
        /// 해당 객체 필드를 초기화한다.
        /// </summary>
        public void ResetGame()
        {
            Strikes = Balls = 0;
            Count = 1;
            MakeRandomNumbers();
        }
        /// <summary>
        /// 새로운 arrLength 크기의 랜덤숫자 배열 생성
        /// </summary>
        /// <param name="arrLength">배열크기</param>
        public void MakeRandomNumbers()
        {
            randomArray = new char[ArrLength];
            for (int i = 0; i < randomArray.Length; i++) // 0 - x, 1 - 0, 2 - 1, 0 ...  비교
            {
                randomArray[i] = Convert.ToChar(rand.Next(0, 9).ToString()); // i번째 입력 후 이전값들과 비교
                for (int j = i - 1; j >= 0; j--)
                {
                    if (randomArray[i] == randomArray[j]) // 이전 값에 걸릴경우
                    {
                        randomArray[i] = Convert.ToChar(rand.Next(0, 9).ToString()); // 변경
                        j = i; // i -1번째부터 비교 j--를 실행해야 하기때문에 i대입
                    }
                }
            }
        }
        /// <summary>
        /// 입력받은 값이 MakeRandomNumbers를 했던 배열과 비교,
        /// 숫자 형식인지 중복으로 같은 값을 입력했는지 확인하고 Exception타입으로 throw한다.
        /// </summary>
        /// <param name="inputNumbers">사용자가 입력한 값</param>
        /// <returns>string으로 변경한 값</returns>
        public void CheckInputNumbers(string inputNumbers)
        {
            // 입력받은 값이 게임에서 만든 배열보다 큰지? or 작은지
            string str = string.Format("{0}개의 숫자를 입력해 주세요", randomArray.Length);
            if (inputNumbers.Length > randomArray.Length || inputNumbers.Length < randomArray.Length) throw new Exception(str);

            // 입력받은 값이 숫자인지?
            int numbers = 0;
            bool isSuccess = int.TryParse(inputNumbers, out numbers);
            if (!isSuccess) throw new Exception("숫자만 입력해주세요.");

            // 입력받은 값 중에 중복 값이 있는지?
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    if (inputNumbers[i] == inputNumbers[j]) throw new Exception("같은 숫자를 입력하지 마세요.");
                }
            }
        }
        /// <summary>
        /// 사용자가 입력한 값으로 ball, strike값을 설정한다.
        /// </summary>
        /// <param name="inputNumbers">사용자가 입력한 값</param>
        public void CheckStrikesAndBalls(string inputNumbers)
        {
            // 볼, 스트라이크 초기화
            Balls = Strikes = 0;

            // 여러 길이의 야구게임을 위한 처리
            char[] charArr = inputNumbers.ToCharArray();
            //

            // 입력값과 랜덤값 비교
            for (int i = 0; i < randomArray.Length; i++)
            {
                for (int j = 0; j < randomArray.Length; j++)
                {
                    Debug.WriteLine("Alambana.RandomNumberGame :: randomArray[{0}]'{1}' <-> charArr[{2}]{3} ", i, randomArray[i], j, charArr[i]);
                    if (randomArray[i] == charArr[j] && i == j)
                    {
                        Strikes++;
                        break;
                    }
                    else if (randomArray[i] == charArr[j])
                    {
                        Balls++;
                        break;
                    }
                }
            }
            //
        } // CheckStrikesAndBalls

        /// <summary>
        /// 난이도 선택, 난이도에 따라 최대 시도횟수, 게임 배열길이가 달라진다.
        /// </summary>
        public void SetLevel()
        {
            try
            {
                Console.Write("난이도 선택 : 1.상, 2.중, 3.하 :: ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        MaxCount = 8;
                        ArrLength = 4;
                        break;
                    case "2":
                        MaxCount = 10;
                        ArrLength = 3;
                        break;
                    case "3":
                        MaxCount = 10;
                        ArrLength = 2;
                        break;
                    default:
                        throw new Exception("1, 2, 3 중 하나를 선택해주세요");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                SetLevel();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp0919
{
    class stringHandle
    {
        static void Main(string[] args)
        {

            /// 
            char[,] heart = new char[5, 5];
            char into = 'ㅇ';
            int S = 1, E = 5;
            for (int i = 0; i < 5; i++)
            {
                S += i;
                E -= i;
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 && j % 2 == 1)
                    {
                        heart[i, j] = into;
                    }
                    else if ((i >= S) && (i <= E))
                    {
                        heart[i, j] = into;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,2}", heart[i, j]);
                }
                Console.WriteLine();
            }
            ///

            string str01 = "가나다라마바사";
            System.String str02 = "가나다라마바사";
            String str03 = "가나다라마바사";
            string str04 = new string(new char[7] { '가', '나', '다', '라', '마', '바', '사' });

            Console.WriteLine("string:\t\t{0}", str01);
            Console.WriteLine("System.String:\t{0}", str02);
            Console.WriteLine("String:\t\t{0}", str03);
            Console.WriteLine("char[]:\t\t{0}", str04);
            //-----------------------------------------------------------------------

            //Insert 메소드
            string str1 = "반갑습니다.";
            str1 = str1.Insert(str1.Length, "홍길동님");
            Console.WriteLine(str1.Insert(0, "앗! "));

            //Concat 메소드
            string str2 = String.Concat("가", "나", "다");
            Console.WriteLine(str2);

            //+연산자
            string str3 = "가" + "나" + "다";
            Console.WriteLine(str3);
            //-----------------------------------------------------------------------

            string str = "Sometimes I fear that I will forget all of my passwords.";

            str = str.ToUpper();
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str);
            //-----------------------------------------------------------------------

            string strT = " 잘 살아 보세 ";

            Console.WriteLine("[{0}]", strT);

            Console.WriteLine("[{0}]", strT.TrimStart());
            Console.WriteLine("[{0}]", strT.TrimEnd());

            Console.WriteLine("[{0}]", strT.Trim());
            Console.WriteLine("[{0}]", strT.TrimStart().TrimEnd());
            //-----------------------------------------------------------------------

            string strR = " Lost World ";

            Console.WriteLine("[{0}]", strR);

            Console.WriteLine("[{0}]", strR.Replace(" ", ""));
            Console.WriteLine("[{0}]", strR.Replace("World", "Home"));
            Console.WriteLine("[{0}]", strR.Replace(" ", "").Replace("World", "Home"));
            strR = strR.Replace(" ", "").Replace("World", "Home");
            Console.WriteLine(strR);
            ///========================================
            string row = "나는 문자열이다.";

            Console.WriteLine(row.Remove(3, 3)); // row.Replace("문자열","");
            Console.WriteLine(row.Replace("문자열", ""));
            Console.WriteLine(row.Substring(0,3) + row.Substring(6, 3)); // start index, length(생략시 끝까지)
            Console.WriteLine(row);

            ///========================================

            str = "I Love You";

            Console.WriteLine(str.IndexOf("Love"));
            Console.WriteLine(str.LastIndexOf("You"));

            Console.WriteLine(str.Substring(2, 4));
            Console.WriteLine(str.Substring(2));

            //Console.Write("문자열을 입력하세요: ");
            //string question = Console.ReadLine();

            //Console.Write("검색할 키워드를 입력하세요: ");
            //string keyword = Console.ReadLine();

            //int search = question.IndexOf(keyword);
            //if (search == -1)
            //    Console.WriteLine("검색된 결과가 없습니다.");
            //else
            //    Console.WriteLine("검색된 키워드는 {0}에서 {1}사이에 있습니다.", search, search + keyword.Length);
            //-----------------------------------------------------------------------

            str = String.Format("포맷된 문자열 {0,10}", "ABC");
            Console.WriteLine(str);
            ///========================================

            string csv = "아이유,최지우,김희선,김하늘,이효리";
            string[] result;

            result = csv.Split(',');

            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);
            //-----------------------------------------------------------------------
            StringBuilder sb2 = new StringBuilder();
            string csv_new;
            foreach (string arg in result)
            {
                sb2.Append(arg);
                sb2.Append(",");
            }
            csv_new = sb2.ToString().TrimEnd(',');
            Console.WriteLine(csv_new);
            ///========================================
            str1 = "I am a boy";
            str2 = "I am a boy";
            str3 = "I am a Boy";

            if (str1.Equals(str2))
                Console.WriteLine("str1과 str2는 똑같네요.");
            else
                Console.WriteLine("str1과 str2는 안 똑같네요.");

            if (String.Equals(str1, str2))
                Console.WriteLine("str1과 str2는 똑같네요.");
            else
                Console.WriteLine("str1과 str2는 안 똑같네요.");

            if (str2.Equals(str3))
                Console.WriteLine("str2와 str3는 똑같네요.");
            else
                Console.WriteLine("str2와 str3는 안 똑같네요.");
            //-----------------------------------------------------------------------

            StringBuilder sb = new StringBuilder("I am a Boy", 18); // 늘어난다. => 넉넉하게 늘어남

            sb.Append(". Your are a Girl.\n");
            sb.AppendFormat("{0,10}", "Thanks");

            Console.WriteLine(sb.ToString()); //sb.Capacity ?

            //읽기 및 쓰기가 가능하다.
            Console.WriteLine("sb[0] = {0}", sb[0]);
            sb[0] = 'i';
            Console.WriteLine("sb[0] = {0}", sb[0]);
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.ToString().Trim());
            Console.WriteLine(sb.ToString().IndexOf("Boy"));

        }
    }
}

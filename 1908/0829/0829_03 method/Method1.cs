using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0829_03_method
{
    class Calculator
    {
        public int Div(int a, int b)
        {
            return a / b; // 확장성 ㅇ
        }
        public int Add(int a, int b=10) // 기본값 주기 ( 하나만 넘겨주고싶을 때 )
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Address
    {
    }

    class Method1
    {
        public static void PrintProfile(string name, string phone="")
        { // 이름, 핸드폰 번호 출력
            Console.WriteLine("name : {0}, phone : {1}", name, phone);
        }

        public static void MyConsole(string[] args) // 매개변수 받기
        {
            foreach (var str in args)
            {
                Console.Write(str+'\t');
            }
        }
        public static void MyConsoleParam(params string[] args) // 가변으로 매개변수 받기
        {
            foreach (var str in args)
            {
                Console.Write(str + '\t');
            }
        }

        public static void Main(string[] args) // 전체적인 흐름 : static이 없으면 실행x => static은 static 함수만 부를 수 이씀..?
        {
            foreach (var str in args)
            {
                Console.Write(str + '\t');
            }

            Console.WriteLine("메소드란?");

            PrintProfile("홍길동", "010-1111-2222");
            PrintProfile("김개똥");
            PrintProfile(name:"아이유", phone:"010-2222-3333"); // 파라미터 이름 명시
            PrintProfile(phone:"010-3333-4444", name: "방탄");

            Calculator cal = new Calculator();
            Random ran = new Random();

            int a = ran.Next(10), b = ran.Next(1,10); // 나눌 때 0으로 나누면 안됨

            Console.WriteLine("{0} + {1} = {2}", a, b, cal.Add(a, b));
            Console.WriteLine("{0} + {1} = {2}", a, 10, cal.Add(a)); // 기본값 a + 10
            Console.WriteLine("{0} / {1} = {2}", a, b, cal.Div(a, b));
            Console.WriteLine("{0} / {1} = {2}", 30, 10, cal.Div(b:10, a:30));

            // 배열 생성- 매개변수
            string[] abc = new string[] { "aa", "bb", "cc" };
            MyConsole(abc);

            // 파라미터- 가변길이 파라미터
            MyConsoleParam("aa", "bb");
            MyConsoleParam("aa", "bb","cc");
            MyConsoleParam("aa", "bb","cc","dd");
        }
    }
}

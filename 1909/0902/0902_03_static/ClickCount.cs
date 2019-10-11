using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902_03_static
{
    class ClickCount
    {
        public static void Main(string[] args)
        {
            // static 사용
            Button.btnCountA = 1; // static 변수 사용, 정적 필드
            Button.SetButtonCnt(1); // static 메서드

            Button btn1 = Button.CreateInstanse();
            btn1.GetButtonCnt(); // 1 : 인스턴스 메서드, 인스턴스 필드
            btn1.Click();
            btn1.Click();
            btn1.Click();
            btn1.Click();
            btn1.Click();
            Button btn2 = Button.CreateInstanse();
            Button btn3 = Button.CreateInstanse();
            Button btn4 = Button.CreateInstanse();
            btn4.Click();
            Button btn5 = Button.CreateInstanse(); // => Button은 다 같은 객체임
            btn5.GetButtonCnt(); // 5
        }
    }

    class Button
    {
        int btnCount = 0; // 인스턴스 멤버 변수
        static public int btnCountA = 0; // 정적 멤버 (static)
        // 공용 static메모리 공간에 올라가기 때문에 여러 Button을 선언하더라도 메모리공간에서 btnCountA는 하나만 있다.
        // static은 모든 인스턴스가 같은 값을 쓸 때만 사용
        // 인스턴스 메서드 - 정적, 인스턴스 메서드 호출ㅇ , 정적 메서드 - 정적 메서드 호출 ㅇ

        // 딱 한번만 선언하고자 할때 p115
        static public Button btn; 
        public static Button CreateInstanse()
        {
            if (btn == null)
                btn = new Button();
            return btn;
        }

        private Button() { } // 기본생성자 => public / private 생성자가 필요함
        //

        /*
                static Button()
                {
                    //btnCount = 1; // static - 인스턴스 x
                    btnCountA = 1; // static - static o
                }
        */
        /*
                public Button()
                {
                    btnCount = ++btnCountA;
                    Console.WriteLine(btnCountA + "번째 버튼");
                }
        */
        public static void SetButtonCnt(int bCnt)
        {
            btnCountA = bCnt;
        }

        int clickCnt = 0;
        public void Click()
        {
            clickCnt++;
            Console.WriteLine(btnCount + "번째 버튼 :: " + clickCnt);
        }
        public void GetButtonCnt()
        {
            Console.WriteLine(btnCountA);
        }
    }

}

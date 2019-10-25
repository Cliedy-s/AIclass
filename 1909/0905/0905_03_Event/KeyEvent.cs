using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_03_Event
{
    class MyButton
    {
        public delegate void ClickEvent(object sender, MyEventArgs args); // 델리게이트 클래스 정의
        public event ClickEvent Click; // 식별자 선언
        public string text;

        // 생성자
        public MyButton() : this("") { }
        public MyButton(string text)
        {
            this.text = text;
            this.AddOnMyButton(MyButton.OnClick); // onclick 메서드를 델리게이트로 감싸서 AddOnMyButton에 전달 => click에 OnClick 함수 추가
        }
        // => 객체 생성시 text에 전달된 문자열을 넣고, Click델리게이트에 OnClick함수를 추가한다.

        // 메소드
        public void ButtonClick(int clickCount)
        {
            if (Click != null) // Click에 함수가 들어있으면 해당 함수들을 실행한다.
            {
                MyEventArgs args = new MyEventArgs(clickCount);
                Click(this, args);
            }
        }
        //

        public static void OnClick(object sender, MyEventArgs args)
        {
            MyButton btn = (MyButton)sender;
            Console.WriteLine( "[ {0} ] 버튼이 [ {1} ]번 클릭 되었습니다", btn.text, args.GetClickCount());
        }

        public void AddOnMyButton(ClickEvent handler)
        {
            Click += handler; // click 델리게이트에 handler로 전달된 함수 추가
        }

        public void RemoveOnMyButton(ClickEvent handler)
        {
            Click -= handler; // 
        }
        //

        // 종료자
        ~MyButton() // 종료시 onclick메서드를 해당 객체에서 삭제한다.
        {
            this.RemoveOnMyButton( new MyButton.ClickEvent(MyButton.OnClick) );
        }
        //
    }
    class MyEventArgs : EventArgs
    {
        private int clickCount;

        //
        public MyEventArgs() : this(1) { }
        public MyEventArgs(int clickCount)
        {
            this.clickCount = clickCount;
        }
        //

        //
        public int GetClickCount() { return this.clickCount; }
        //
    }


    /// 
    class Program
    {
        // 메인 함수
        public static void Main()
        {
            MyButton btn1 = new MyButton("Save"); // 버튼 생성 text = "Save", 해당 버튼 객체의 델리게이트(Click)에 OnClick함수 전달
            MyButton btn2 = new MyButton("Exit");

            btn1.ButtonClick(5); // ButtonClick 호출=>Click에 저장된 함수를 모두 실행한다(OnClick)
                                    // ClickCount에 5전달 => ButtonClick(clickCount) { cw( text 버튼이 clickCount번 클릭되었습니다. );}
            btn2.ButtonClick(1); // 원래 윈도우가 대신 호출해줌
        }
    }
}

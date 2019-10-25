using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_03_Event_복사본
{
    class MyButton
    {
        public delegate void ClickEvent(object sender, MyEventArgs args); 
        public event ClickEvent Click; 
        public string text;

        public MyButton() : this("") { }
        public MyButton(string text)
        {
            this.text = text;
            Click += MyButton.OnClick;
        }

        public void ButtonClick(int clickCount)
        {
            if (Click != null)
            {
                MyEventArgs args = new MyEventArgs(clickCount);
                Click(this, args);
            }
        }

        public static void OnClick(object sender, MyEventArgs args)
        {
            MyButton btn = (MyButton)sender;
            Console.WriteLine( "[ {0} ] 버튼이 [ {1} ]번 클릭 되었습니다", btn.text, args.GetClickCount());
        }

        ~MyButton() 
        {
            Click -= new MyButton.ClickEvent(MyButton.OnClick);
        }
    }

    class MyEventArgs : EventArgs
    {
        private int clickCount;

        public MyEventArgs() : this(1) { }
        public MyEventArgs(int clickCount)
        {
            this.clickCount = clickCount;
        }
        public int GetClickCount() { return this.clickCount; }
    }


    /// 
    class Program
    {
        public static void Main()
        {
            MyButton btn1 = new MyButton("Save"); 
            MyButton btn2 = new MyButton("Exit");

            btn1.ButtonClick(5); 
            btn2.ButtonClick(1); 
        }
    }
}

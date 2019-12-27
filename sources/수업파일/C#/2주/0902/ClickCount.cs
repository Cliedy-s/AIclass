using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0902
{
    class Button
    {
        int click = 0;
        static int buttonCnt = 0;

        public Button()
        {
            buttonCnt++;
            Console.WriteLine("버튼 {0}", buttonCnt);
        }

        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
    }

    class ClickCountTest
    {
        static void Main(string[] args)
        {
            Button c1 = new Button();
            c1.Click();
            c1.Click();
            c1.Click();
            c1.Click();
            c1.Click();

            Button c2 = new Button();
            Button c3 = new Button();
            Button c4 = new Button();
            Button c5 = new Button();
        }
    }
}

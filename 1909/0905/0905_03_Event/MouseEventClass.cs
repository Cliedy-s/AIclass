using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_03_Event
{/// <summary>
 /// EventClass에 대한 요약 설명입니다.
 /// </summary>
    class Mouse
    {
        // click, move 이벤트 델리게이트 클래스 정의
        public delegate void ClickEvent(object sender, EventArgs E);
        public delegate void MoveEvent(object sender, EventArgs E);
        //

        // 델리게이트 사용을 위한 식별자
        public event ClickEvent Click;
        public event MoveEvent Move;
        //

        public void OnMouseLeftClick()
        {
            // click에 메서드를 추가했을 때
            if (Click != null)
            {
                Console.WriteLine("왼쪽 마우스 클릭 이벤트가 발생했군요"); // (1) 
                EventArgs E = new EventArgs(); // (2)
                Click(this, E); // Click => MouseEventMethod.OnMouseLeftClick(this, E);
            }
        }
    }

    class MouseEventMethod
    {
        public void OnMouseLeftClick(object sender, EventArgs E)
        {
            Console.WriteLine("마우스 왼쪽버튼이 눌려졌을때의 처리 중..");
        }
    }


    public class MouseEventClass
    {
        [STAThread] // Single-Threaded Apartment
        static void Main(string[] args)
        {
            MouseEventMethod m = new MouseEventMethod(); // 메서드 모음??용 객체 인듯
            Mouse LMouseClick = new Mouse();

            LMouseClick.Click += new Mouse.ClickEvent(m.OnMouseLeftClick); // MouseEventMethod.OnMouseLeftClick() { "마우스 왼쪽버튼이 눌려졌을때의 처리 중.." } => click에 추가
            LMouseClick.OnMouseLeftClick(); // => OnMouseLeftClick

        }
    }
}

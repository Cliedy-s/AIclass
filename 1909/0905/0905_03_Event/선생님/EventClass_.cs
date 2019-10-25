using System;

namespace Demo13th
{
	/// <summary>
	/// EventClass에 대한 요약 설명입니다.
	/// </summary>
	class Mouse
	{
		//위임 정의(이벤트 핸들러 메소드의 원형을 정의)
		public delegate void ClickEvent(object sender, EventArgs E);
		public delegate void MoveEvent(object sender, EventArgs E);

		//이벤트 정의
		public event ClickEvent Click;
		public event MoveEvent Move;
		
		public void OnMouseLeftClick()
		{
			//등록된 이벤트 핸들러가 있는지 조사
			if(Click != null)
			{
				Console.WriteLine("왼쪽 마우스 클릭 이벤트가 발생했군요");
				EventArgs E = new EventArgs();
				//이벤트 호출
				Click(this, E);
			}
		}
	}

	class MouseEventMethod
	{
		//이벤트 핸들러, 위임의 메소드 형식과 동일
		public void OnMouseLeftClick(object sender, EventArgs E)
		{
			Console.WriteLine("마우스 왼쪽버튼이 눌려졌을때의 처리 중..");
		}
	}	


	public class EventClass
	{
		[STAThread]
		static void Main(string[] args)
		{
			MouseEventMethod m = new MouseEventMethod();

			Mouse LMouseClick = new Mouse();

			//Click이라는 이벤트에 이벤트 핸들러등록
			LMouseClick.Click += new Mouse.ClickEvent(m.OnMouseLeftClick);

			//Click이벤트 발생
			LMouseClick.OnMouseLeftClick();
		}
	}
}

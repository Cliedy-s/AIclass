using System;

class MyButton
{
	//위임 선언 = 이벤트 핸들러 유형
	public delegate void ClickEvent(object sender, MyEventArgs args);

	//이벤트 선언
	public event ClickEvent Click;

	//버튼의 텍스트
	public string text;

	//빈 생성자
	public MyButton() : this("") {}

	//문자열 인자 생성자
	public MyButton(string text)
	{
		//문자열로 버튼 텍스트 초기화
		this.text = text;

		//이벤트에 MyButton.OnClick 이벤트 핸들러를 등록
		this.AddOnMyButton(
			new MyButton.ClickEvent(MyButton.OnClick)
		);
	}

	//이벤트 발생 메소드
	//clickCount는 몇 번 클릭되었는지의 정수 값
	public void ButtonClick(int clickCount)
	{
		//등록된 이벤트 핸들러가 있는지를 조사
		if( Click != null )
		{
			//clickCount로 이벤트 인자 객체 생성
			MyEventArgs args = new MyEventArgs(clickCount);

			//이벤트 호출 sender는 this가 된다
			Click(this, args);
		}
	}

	//MyButton 이벤트 핸들러. 위임의 메소드 형식과 같다
	public static void OnClick(object sender, MyEventArgs args)
	{
		//object를 MyButton 객체 형식으로 변환
		MyButton btn = (MyButton) sender;

		//버튼이 클릭될 경우의 처리 방식
		//여기서는 간단히 어떤 버튼이 호출되고
		//몇 번 클릭되었는지를 출력
		//클릭 개수는 args.GetClickCount 메소드로 정수 값 반환
		Console.WriteLine(
			"[ {0} ] 버튼이 [ {1} ]번 클릭 되었습니다",
			btn.text, args.GetClickCount());
	}

	//이벤트 핸들러 등록 메소드로 
	//위임형 핸들러 객체를 받는다
	public void AddOnMyButton(ClickEvent handler)
	{
		//이벤트 Click에 이벤트 핸들러 추가
		Click += handler;
	}

	//이벤트 핸들러 제거 메소드
	public void RemoveOnMyButton(ClickEvent handler)
	{
		Click -= handler;
	}

	//소멸자
	//자동으로 이벤트 핸들러 제거 메소드를 실행하나
	//그다지 유용한 작업은 아니다. 다만 예로 표현
	~MyButton()
	{
		this.RemoveOnMyButton(
			new MyButton.ClickEvent(MyButton.OnClick)
		);
	}
}

//이벤트 파라미터 객체로 System.EventArgs 객체를 상속
class MyEventArgs : EventArgs
{
	//클릭 카운트 멤버 변수
	private int clickCount;

  //빈 생성자
	public MyEventArgs() : this(1) {}

	//인자 있는 생성자
	public MyEventArgs(int clickCount)
	{
		this.clickCount = clickCount;
	}

	//클릭 카운트를 얻는 메소드
	public int GetClickCount() { return this.clickCount; }
}

//메인 프로그램
class Program
{
	public static void Main()
	{
		//버튼 객체 생성
		MyButton btn1 = new MyButton("Save");
		MyButton btn2 = new MyButton("Exit");

		//버튼을 클릭한다. 즉 이벤트 호출
		btn1.ButtonClick(5);
		btn2.ButtonClick(1);
	}
}
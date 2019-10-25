using System;

class MyButton
{
	//���� ���� = �̺�Ʈ �ڵ鷯 ����
	public delegate void ClickEvent(object sender, MyEventArgs args);

	//�̺�Ʈ ����
	public event ClickEvent Click;

	//��ư�� �ؽ�Ʈ
	public string text;

	//�� ������
	public MyButton() : this("") {}

	//���ڿ� ���� ������
	public MyButton(string text)
	{
		//���ڿ��� ��ư �ؽ�Ʈ �ʱ�ȭ
		this.text = text;

		//�̺�Ʈ�� MyButton.OnClick �̺�Ʈ �ڵ鷯�� ���
		this.AddOnMyButton(
			new MyButton.ClickEvent(MyButton.OnClick)
		);
	}

	//�̺�Ʈ �߻� �޼ҵ�
	//clickCount�� �� �� Ŭ���Ǿ������� ���� ��
	public void ButtonClick(int clickCount)
	{
		//��ϵ� �̺�Ʈ �ڵ鷯�� �ִ����� ����
		if( Click != null )
		{
			//clickCount�� �̺�Ʈ ���� ��ü ����
			MyEventArgs args = new MyEventArgs(clickCount);

			//�̺�Ʈ ȣ�� sender�� this�� �ȴ�
			Click(this, args);
		}
	}

	//MyButton �̺�Ʈ �ڵ鷯. ������ �޼ҵ� ���İ� ����
	public static void OnClick(object sender, MyEventArgs args)
	{
		//object�� MyButton ��ü �������� ��ȯ
		MyButton btn = (MyButton) sender;

		//��ư�� Ŭ���� ����� ó�� ���
		//���⼭�� ������ � ��ư�� ȣ��ǰ�
		//�� �� Ŭ���Ǿ������� ���
		//Ŭ�� ������ args.GetClickCount �޼ҵ�� ���� �� ��ȯ
		Console.WriteLine(
			"[ {0} ] ��ư�� [ {1} ]�� Ŭ�� �Ǿ����ϴ�",
			btn.text, args.GetClickCount());
	}

	//�̺�Ʈ �ڵ鷯 ��� �޼ҵ�� 
	//������ �ڵ鷯 ��ü�� �޴´�
	public void AddOnMyButton(ClickEvent handler)
	{
		//�̺�Ʈ Click�� �̺�Ʈ �ڵ鷯 �߰�
		Click += handler;
	}

	//�̺�Ʈ �ڵ鷯 ���� �޼ҵ�
	public void RemoveOnMyButton(ClickEvent handler)
	{
		Click -= handler;
	}

	//�Ҹ���
	//�ڵ����� �̺�Ʈ �ڵ鷯 ���� �޼ҵ带 �����ϳ�
	//�״��� ������ �۾��� �ƴϴ�. �ٸ� ���� ǥ��
	~MyButton()
	{
		this.RemoveOnMyButton(
			new MyButton.ClickEvent(MyButton.OnClick)
		);
	}
}

//�̺�Ʈ �Ķ���� ��ü�� System.EventArgs ��ü�� ���
class MyEventArgs : EventArgs
{
	//Ŭ�� ī��Ʈ ��� ����
	private int clickCount;

  //�� ������
	public MyEventArgs() : this(1) {}

	//���� �ִ� ������
	public MyEventArgs(int clickCount)
	{
		this.clickCount = clickCount;
	}

	//Ŭ�� ī��Ʈ�� ��� �޼ҵ�
	public int GetClickCount() { return this.clickCount; }
}

//���� ���α׷�
class Program
{
	public static void Main()
	{
		//��ư ��ü ����
		MyButton btn1 = new MyButton("Save");
		MyButton btn2 = new MyButton("Exit");

		//��ư�� Ŭ���Ѵ�. �� �̺�Ʈ ȣ��
		btn1.ButtonClick(5);
		btn2.ButtonClick(1);
	}
}
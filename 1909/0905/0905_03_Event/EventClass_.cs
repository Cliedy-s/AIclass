using System;

namespace Demo13th
{
	/// <summary>
	/// EventClass�� ���� ��� �����Դϴ�.
	/// </summary>
	class Mouse
	{
		//���� ����(�̺�Ʈ �ڵ鷯 �޼ҵ��� ������ ����)
		public delegate void ClickEvent(object sender, EventArgs E);
		public delegate void MoveEvent(object sender, EventArgs E);

		//�̺�Ʈ ����
		public event ClickEvent Click;
		public event MoveEvent Move;
		
		public void OnMouseLeftClick()
		{
			//��ϵ� �̺�Ʈ �ڵ鷯�� �ִ��� ����
			if(Click != null)
			{
				Console.WriteLine("���� ���콺 Ŭ�� �̺�Ʈ�� �߻��߱���");
				EventArgs E = new EventArgs();
				//�̺�Ʈ ȣ��
				Click(this, E);
			}
		}
	}

	class MouseEventMethod
	{
		//�̺�Ʈ �ڵ鷯, ������ �޼ҵ� ���İ� ����
		public void OnMouseLeftClick(object sender, EventArgs E)
		{
			Console.WriteLine("���콺 ���ʹ�ư�� ������������ ó�� ��..");
		}
	}	


	public class EventClass
	{
		[STAThread]
		static void Main(string[] args)
		{
			MouseEventMethod m = new MouseEventMethod();

			Mouse LMouseClick = new Mouse();

			//Click�̶�� �̺�Ʈ�� �̺�Ʈ �ڵ鷯���
			LMouseClick.Click += new Mouse.ClickEvent(m.OnMouseLeftClick);

			//Click�̺�Ʈ �߻�
			LMouseClick.OnMouseLeftClick();
		}
	}
}

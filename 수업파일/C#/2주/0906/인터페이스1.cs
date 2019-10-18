using System;

namespace Demo12th
{
	/// <summary>
	/// �⺻ �������̽�
	/// </summary>
	interface IMan
	{
		string FirstName { get; set;}
		string LastName { get; set;}
		void Save();
		void Show();
	}

	//�������̽��� �������̽��� ����� ����̹Ƿ�, �������� �ʾƵ� �ȴ�.
	interface IPerson : IMan
	{
		
	}

	class Employee5 : IPerson
	{
		private int intEmployeeID;
		private string strFName;
		private string strLName;

		public int EmployeeId
		{
			get { return intEmployeeID;}
			set { intEmployeeID = value;}
		}

		public string FirstName
		{
			get { return strFName;}
			set { strFName = value;}
		}

		public string LastName
		{
			get { return strLName;}
			set { strLName = value;}
		}

		
		public Employee5() 
		{
			Console.WriteLine("EmployeeClass�� �⺻ ������ ȣ��");
		}

		public Employee5(int EmployeeId)
		{
			intEmployeeID = EmployeeId;
			FirstName = "Kim";
			LastName = "Tae Hee";
		}
		
		public void Show()
		{
			System.Console.WriteLine("==========Person==================");
			System.Console.WriteLine(" EmployeeId : {0}", intEmployeeID);
			System.Console.WriteLine(" FirstName  : {0}", FirstName);
			System.Console.WriteLine(" LastName   : {0}", LastName);
			System.Console.WriteLine("==================================");
		}

		public void Save()
		{
			System.Console.WriteLine(" FirstName  : {0}", FirstName);
			System.Console.WriteLine(" LastName   : {0}", LastName);
		}
	}

	class interface_basic
	{
		[STAThread]
		static void Main(string[] args)
		{
			Employee5 empEmployee = new Employee5();
			IPerson perPerson; 

			empEmployee.EmployeeId = 25;

			perPerson = empEmployee;

	       perPerson.FirstName = "Hong";
	       perPerson.LastName = "kil dong";
			perPerson.Show();        //�������̽��� ������ ������ ȣ��
			empEmployee.Show();      //public�̴ϱ� �ν��Ͻ��� �ٷ� ȣ��
		}
	} 
}

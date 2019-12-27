using System;

namespace Demo12th
{
	/// <summary>
	/// 기본 인터페이스
	/// </summary>
	interface IMan
	{
		string FirstName { get; set;}
		string LastName { get; set;}
		void Save();
		void Show();
	}

	//인터페이스가 인터페이스를 상속한 경우이므로, 구현하지 않아도 된다.
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
			Console.WriteLine("EmployeeClass의 기본 생성자 호출");
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
			perPerson.Show();        //인터페이스를 구현한 것으로 호출
			empEmployee.Show();      //public이니까 인스턴스로 바로 호출
		}
	} 
}

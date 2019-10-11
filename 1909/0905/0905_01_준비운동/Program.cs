using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_01_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee(1313, "Hello", "Welcome");
            em.Show();
        }
    }
    abstract class Person
    {
        string firstName = string.Empty, lastName = string.Empty;

        public Person(string FirstName, string LastName) // 생성자 프로퍼티로 설정 
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        abstract public void Show();
    }

    class Employee : Person
    {
        int employeeID = 0;

        public Employee() : this(0) { }
        public Employee(int employeeID): this(employeeID, "No", "Name") {  }
        public Employee(int employeeID, string FirstName, string LastName) : base(FirstName, LastName) // 생성자 접근 ㅇ
        {
            this.employeeID = employeeID;
        }

        override public void Show()
        {
            Console.WriteLine("{0} : {1} {2}", employeeID, FirstName, LastName); // employee가 상속받더라도 접근은 Person.firstName이라 프로퍼티가 필요함
        }
    }
}

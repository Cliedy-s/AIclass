using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903_02_상속
{
    class Person
    {
        private string strFName;
        public string FirstName
        {
            get { return strFName; }
            set { strFName = value; }
        }
        private string strLName;
        public string LastName
        {
            get { return strLName; }
            set { strLName = value; }
        }

        public Person() { } // 자식 객체 생성 (1) 실행
        public Person(string strFName, string strLName)
        {
            FirstName = strFName;
            LastName = strLName;
        }

        public virtual void Show() // 가상함수 : 상속받은 사람이 바꿀 수 있다. <-> 추상함수 : 상속받은 사람이 반드시 바꿔야 한다.
                                   //public virtual void Show() => 가상함수
        {
            Console.WriteLine("=========Person=========");
            Console.WriteLine("First Name : {0} ", FirstName);
            Console.WriteLine("Last Name : {0} ", LastName);
            Console.WriteLine("========================");
        }
        //
        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   strFName == person.strFName &&
                   strLName == person.strLName;
        }
        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
/*
        //
        public override int GetHashCode()
        {
            var hashCode = 1938039292;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            return hashCode;
        }
        //
*/

        /*(1)
            public override string ToString() // override => virtual포함
{
  return string.Format("{0}{1}", FirstName, LastName);
}
*/
        /*
                public override string ToString() // override => virtual포함
                {
                    return string.Format("{0}{1}", FirstName, LastName);
                }
        */


    }

    class Employee : Person // Person을 상속받는다.
    {
        int employeeID;
        public Employee(int employeeID, string strFName, string strLName) : base(strFName, strLName) // 자식 객체 생성 (2) 실행 
                                                                                                     // => base가 없을 시 기본 생성자를 부른다.
                                                                                                     // 생성자 선택? :  base( , ) < - > this() : 같은 생성자
        {
            this.employeeID = employeeID;
        }
        /*
                // show() 재정의
                public new void Show() // override <-> new
                {
                    Console.WriteLine("========Employee========");
                    Console.WriteLine("Employee ID : {0}", this.employeeID);
                    Console.WriteLine("First Name : {0} ", FirstName); // x => strFName 
                    Console.WriteLine("Last Name : {0} ", LastName);
                    Console.WriteLine("========================");
                }
        */

        /*(1)
                public override string ToString()
                {
                    return string.Format("{0} : {1}{2}",employeeID, FirstName, LastName);
                }
        */
        /*
                public override string ToString()
                {
                    return string.Format("{0} : {1}", employeeID, base.ToString());
                }
        */
    }

    class Inherit_Base
    {
        static void Main(string[] args)
        {
            Person p = new Person("아", "이유");
            Person p3 = new Person("아", "이유");
            p.Show();

            Employee e = new Employee(2019005, "직", "원");
            e.Show();

            // 부모:virtual, 자식:override (.show) => 태생의 메소드를 가짐
            // 부모x, 자식:new (.show) => 무조건 현재 타입의 메소드를 실행

            // Employee e2 = (Employee)p; // 오류o : 부모 => 자식
            // e2.Show();

            Person p2 = e; // 오류x : 자식 => 부모 // 암시적 형변환
            p2.Show();
            Employee e3 = (Employee)p2; // 오류x : 자식 => 부모 => 자식 // 명시적 형변환
            e3.Show();
            Console.WriteLine(p.ToString());
            Console.WriteLine(e.ToString()); // override x=> 클래스 풀네임
            Console.WriteLine(p.Equals(p3));
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(e.GetHashCode());
            // <=> 형제-> 형제 => 오류오륭류오류오류올유로유롱류


            // Employee e2 = (Employee)p; :: 오류 
            //     => 개선
            // as : 해당 타입으로 형변환된 객체 반환
            Employee e2 = p as Employee;
            if (e2 != null)
                e2.Show();
            // is : 해당 타입으로 형변환 가능한지 여부 반환
            if (p is Employee)
            {
                Employee e4 = (Employee)p;
                e4.Show();
            }

        }
    }
}

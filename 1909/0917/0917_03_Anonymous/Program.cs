using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0917_03_Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            // 익명 클래스
            var anonymousTypev = new { Name = "홍길동", Age = 20 }; // Person과 비슷
            dynamic anonymousTyped = new { Name = "홍길동", Age = 20 };
            object TypeO = new { Name = "홍길동", Age = 20 };
            var anonymouseTypevArr = new[] {
                new { Name = "김길동", Age = 20 },
                new { Name = "청길동", Age = 20 },
                new { Name = "창길동", Age = 20 },
            };

            Person TypeP = new Person();

            string name = anonymousTypev.Name; // var
            name = anonymousTyped.Name; // 인텔리전스 x : dynamic
            //


            // 익명 메서드
            Print dp = print1;
            dp += delegate () { Console.WriteLine("print2"); };
            dp += () => Console.WriteLine("print3");

            // Action, Func 람다 메서드를 위한 전용 델리게이트
            Action<int> ac = (a) => Console.WriteLine("print1" + a); ;
            ac += (b) => Console.WriteLine("print2" + b);
            ac += (c) => Console.WriteLine("print3" +c );
        }
        delegate void Print();
        static void print1()
        {
            Console.WriteLine("print1");
        }
        //
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

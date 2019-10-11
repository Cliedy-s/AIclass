using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    class MyClass
    {
        int number1;
        public int Number1 { get { return number1; } } // 읽기 전용
        public MyClass() { this.number1 = 0; }
        public void Plus1(int value)
        {
            this.number1 += value;
        }
        public void Minus(int value)
        {
            this.number1 -= value;
        }
        static public void PrintHello(int value)
        {
            for (int i = 0; i < value; i++)
                Console.Write("Hello ");
        }
        public void Add(int number1, int number2)
        {
            Console.WriteLine("number1 + number2 = {0}", number1 + number2);
        }
    }
    class MyClass2
    {
        int number1;
        public int Number1 { get { return number1; } } // 읽기 전용
        public MyClass2() { this.number1 = 0; }
        public void Plus2(int value)
        {
            this.number1 += value;
        }
        public void Minus(int value)
        {
            this.number1 -= value;
        }
        static public void PrintHello(int value)
        {
            for (int i = 0; i < value; i++)
                Console.Write("Hello ");
        }
        public void Add(int number1, int number2)
        {
            Console.WriteLine("number1 + number2 = {0}", number1 + number2);
        }
    }

    public delegate void SampleDelegate(int value);
    class Delegate01
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass2 myClass2 = new MyClass2();

            myClass.Plus1(100);
            myClass.Plus1(100);
            Console.WriteLine(myClass.Number1); // 200

            // SampleDelegate s = new SampleDelegate(myClass.Plus); // C#1.0
            SampleDelegate s = myClass.Plus1; // C# 2.0 

            s(500); // myClass.Plue(500); => 200 + 500 => 700
            Console.WriteLine(myClass.Number1);

            s += new SampleDelegate(myClass.Minus); // 복합대입연산자
            s(200); // myClass.Plus(200) + myClass.Minus(200); => 700 +200 -200 => 700
            Console.WriteLine(myClass.Number1);

            s -= myClass.Plus1;
            s(300); // myClass.Minus(300); => 400
            Console.WriteLine(myClass.Number1);

            s += new SampleDelegate(MyClass.PrintHello); // static메소드 호출 가능
            s(3); // myClass.Minus(3) + MyClas.PrintHello(3) =>  Hello Hello Hello 397
            Console.WriteLine(myClass.Number1);

            // s = new SampleDelegate(myClass.Add); // err - 꼴이 안맞아서 에러

            // 잘안씀 ㅎ
            // s = (SampleDelegate) Delegate.Combine(new SampleDelegate(myClass.Minus), new SampleDelegate(myClass.Plus)); // 명시적 형변환 참조(부모)-> 참조(자식)
            // s = (SampleDelegate) Delegate.Remove(s, new SampleDelegate(myClass.Minus));
            //

            // == s += myClass.Plus;

            s = myClass2.Plus2;
            s += myClass.Plus1;
            s += MyClass.PrintHello;

            s(3);
            Console.WriteLine("{0} , {1}",myClass.Number1, myClass2.Number1);

            Console.WriteLine("Target : {0}", s.Target); // 마지막 하나만,  static 클래스는 안나옴
            Console.WriteLine("Method : {0}", s.Method);
        }
    }
}

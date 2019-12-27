using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0829
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public double Add(double a, double b)
        {
            double result = a + b;

            return result;
        }

        public int Div(int a, int b)
        {
            int result = a / b;

            return result;
        }
    }

    class Address
    {
        
    }

    class method1
    {
        public static void PrintProfile(string name, string phone="")
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }

        public static void MyConsole(string[] args)
        {
            foreach (string str in args)
            {
                Console.Write(str + '\t');
            }
        }

        public static void MyConsoleParam(params string[] args)
        {
            foreach (string str in args)
            {
                Console.Write(str + '\t');
            }
        }

        //params : 가변길이 파라미터
        public static void Main(params string[] args)
        {
            foreach (string str in args)
            {
                Console.Write(str + '\t');
            }


            //string[] arr = new string[] { "aa", "bb", "cc" };
            //MyConsole(arr);

            //MyConsoleParam("Hello");
            //MyConsoleParam("Hello", "world");
            //MyConsoleParam("Hello", "world", "ghhhg");


            //PrintProfile("홍길동", "000-1111-1111");

            //PrintProfile("김개똥");

            //PrintProfile(name:"아이유", phone:"222-2222-2222");
            //PrintProfile(phone: "333-3333-3333", name:"방탄아미");


            //Random rand = new Random();
            //int num1 = rand.Next(10);
            //int num2 = rand.Next(10);

            //Calculator cal = new Calculator();
            //int res = cal.Add(num1, num2);

            //res = cal.Add(b:3, a:5);

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, res);

            //Console.WriteLine("{0} / {1} = {2}", num1, num2, cal.Div(num1, num2));

            //Console.WriteLine("{0} + {1} = {2}", a, b, result);
        }
    }
}

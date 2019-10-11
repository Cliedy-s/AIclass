using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_03_M
{
    class MyClass
    {
        public int x = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c1=null;

            PassByValue(c1);
            Console.WriteLine("MyClass : "+c1);

            PassByRef(ref c1);
            Console.WriteLine("MyClass : "+c1 +", X : "+ c1.x);

            PassByOut(out c1);
            Console.WriteLine("MyClass : " + c1 + ", X : " + c1.x);
        }

        static void PassByValue(MyClass c)
        {
            c = new MyClass();
            c.x++;
        }
        static void PassByRef(ref MyClass c)
        {
            c = new MyClass();
            c.x++;
        }
        static void PassByOut(out MyClass c) // c= *  => 강제
        {
            c = new MyClass();
            c.x++;
        }
    }
}

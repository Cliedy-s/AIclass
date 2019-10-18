using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0830
{
    class MyClass
    {
        public int MyFiled1;
        public int MyFiled2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyFiled1 = this.MyFiled1;
            newCopy.MyFiled2 = this.MyFiled2;

            return newCopy;
        }
    }

    class DeepCopy
    {
        static void Main(string[] args)
        {
            //case 얕은복사
            {
                MyClass source = new MyClass();
                source.MyFiled1 = 10;
                source.MyFiled2 = 20;

                MyClass target = source;
                target.MyFiled2 = 30;

                Console.WriteLine("{0} {1}", source.MyFiled1, source.MyFiled2);
                Console.WriteLine("{0} {1}", target.MyFiled1, target.MyFiled2);
            }

            //case 깊은복사
            {
                MyClass source = new MyClass();
                source.MyFiled1 = 10;
                source.MyFiled2 = 20;

                MyClass target = source.DeepCopy();
                target.MyFiled2 = 30;

                Console.WriteLine("{0} {1}", source.MyFiled1, source.MyFiled2);
                Console.WriteLine("{0} {1}", target.MyFiled1, target.MyFiled2);
            }
        }

    }
}

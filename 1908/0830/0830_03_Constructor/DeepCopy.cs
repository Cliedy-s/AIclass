using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_03_Constructor
{
    class DeepCopy
    {
        static void Main(string[] args)
        {
            { //  얕은 복사
                MyClass source = new MyClass(10, 20);
                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine("{0} , {1}", source.MyField2, target.MyField2);
            }
            { // 깊은 복사
                MyClass source = new MyClass(10, 20);
                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine("{0} , {1}", source.MyField2, target.MyField2);
            }
        }
    }
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass()
        {
        }
        public MyClass(int MyField1, int MyField2)
        {
            this.MyField1 = MyField1;
            this.MyField2 = MyField2;
        }

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
}

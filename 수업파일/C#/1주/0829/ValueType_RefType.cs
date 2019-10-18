using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0830
{
    class ValueType_RefType
    {
        static void Main(string[] args)
        {
            int val1 = 10;
            int val2;
            val2 = val1;
            val1 = 100;
            Console.WriteLine("val1:{0}, val2:{1}", val1, val2); // 10, 100

            Data c1 = new Data();
            Data c2;
            c2 = c1;
            c2.r_val = 200;
            Console.WriteLine("c1:{0}, c2:{1}", c1.r_val, c2.r_val); //200, 200

            if (val1 == val2)
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다");

            if (c1 == c2)
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다");
        }
    }

    public class Data
    {
        public int r_val = 0;
    }
}

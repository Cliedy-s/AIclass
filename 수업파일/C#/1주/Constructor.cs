using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0830
{
    class Constructor
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 5);
            Point b = new Point(10, 20);
            Point z = new Point();

            string str = "안녕하세요.";

            Console.WriteLine(str.ToString());
            Console.WriteLine(a.ToString());

            double d = a.Distance(b);
            Console.WriteLine("{3}:{0}와 {1}의 거리: {2}", a, b, d, "결과");
        }
    }
}

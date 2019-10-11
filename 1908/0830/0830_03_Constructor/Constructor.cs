using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830_03_Constructor
{
    class Constructor
    {
        static void Main(params string[] args)
        {
            Point a = new Point(1, 3);
            Point b = new Point(2, 4);

            Point z = new Point(); // 나중에 프로퍼티로 값 대입 ㅇ

            double d = a.Distance(b);
            Console.WriteLine("{3} : {0}과 {1}의 거리 : {2}", a, b, d, "결과"); //object형식 지양
            // a.ToString() => 클래스 풀네임 출력
            string st = "하이";
            Console.WriteLine(st.ToString()); // string은 특별하게 오버라이딩되어있음
        }
    }
}

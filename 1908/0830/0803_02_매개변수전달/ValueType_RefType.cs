using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0803_02_매개변수전달
{
    class ValueType_RefType
    {
        static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 20;
            val2 = val1;
            val2 = 100;
            Console.WriteLine("val1:{0}, val2:{1}", val1, val2); // 10, 100

            // reference type
            Data c1 = new Data(1); // 생성자 호출
            Data c2;
            c2 = c1;
            c2.r_val = 200;
            Console.WriteLine("c1:{0}, c2:{1}", c1.r_val, c2.r_val);
            //200, 200
            /*
                        // 
                        String s1 = "Hello";
                        String s2 = s1;
                        s2 += " World";
                        Console.WriteLine(s1);
                        //
            */
            if (val1 == val2)
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다");

            if (c1 == c2) // => 스택의 값으로 판별 :: c1의 주소값, c2의 주소값
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다"); 
        }
    }

    public class Data // 디어셈블리 issul?
    {
        public int r_val = 0;
        public Data() { } // 같이 만들어 두는게 좋음 :: 상속 때 배움?
        public Data(int val =100) { // 생성자 오버로딩 o
            r_val = val;
        }
    }
}

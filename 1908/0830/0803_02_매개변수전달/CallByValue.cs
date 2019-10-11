using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0803_02_매개변수전달
{
    class CallByValue
    {
        /*
                static void Main(params string[] args)
                {
                    int x = 5, y = 3;
                    Console.WriteLine("x : {0}, y : {1}", x, y);

                    Swap(ref x, ref y);

                    Console.WriteLine("x : {0}, y : {1}", x, y);
                }

                // int a, int b => CallByValue
                // ref int a, ref int b => 참조에 의한 전달
                // out int c, out int d => 출력 전용에 의한 전달
                // c = a, d = b => ref와 비슷, 결과 할당하지 않을 경우 에러
                static void Swap(ref int a,ref int b) // static은 static만 부름 / ref -> 주소값 / 
                {
                    int temp;
                    temp = a;
                    a = b;
                    b = temp;
                }
        */

        static void Swap(int a, int b)
        {
            Console.WriteLine("a :{0}, b :{1}", a, b);
            int temp = b;
            b = a;
            a = b;
            Console.WriteLine("a :{0}, b :{1}", a, b);
        }
        static void SwapByRef(ref int a, ref int b)
        {
            Console.WriteLine("a :{0}, b :{1}", a, b);
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("a :{0}, b :{1}", a, b);
        }

        static void Divide(int a, int b, out int x, out int y)
        {
            x = a / b;
            y = a % b;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x :{0}, y :{1}", x, y);

            //Swap(x, y);

            //값 Type일 경우에 ref 키워드를 붙여주면 함수의 실행결과가 전달된다.
            SwapByRef(ref x, ref y);
            {
                Console.WriteLine("x :{0}, y :{1}", x, y);

                int num1;
                int num2;
                Divide(x, y, out num1, out num2);
                Console.WriteLine("몫 :{0}, 나머지 :{1}", num1, num2);
            }
        }
    }
}

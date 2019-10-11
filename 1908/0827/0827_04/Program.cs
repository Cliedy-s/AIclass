using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float dPi = 3.14f; // 리터럴 ->  형변환 안하게함.
            int iNum = (int)dPi;
            Console.WriteLine(iNum);

            //
            int num1, num2; num1 = num2 = 10;
            const int num3 = 10; // 리턴값, 입력값을 갖고오면 에러 컴파일 시 값이 결정되어야 함.
                                 // num3 = num1 + 1; // (x)
        }
    }
}

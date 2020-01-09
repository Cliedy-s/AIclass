using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0107_01_몸풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            int value=0;
            do Console.Write("정수를 입력하세요:");
            while (!int.TryParse(Console.ReadLine(), out value));

            if (value % 2 == 0 && value>0) value --;
            Console.WriteLine(recursive(value));
        }
        static int recursive(int input)
        {
            Console.Write(input+" ");
            if (input <= 1)
            {
                Console.Write("=");
                return 1;
            }
            Console.Write("*");
            return input * recursive(input -2);
        }
    }
}

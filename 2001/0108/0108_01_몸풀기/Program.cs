using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0108_01_몸풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            int value=0;
            do Console.Write("정수를 입력하세요 : ");
            while (!int.TryParse(Console.ReadLine(), out value));

            // 1번
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2번
            for (int i = 0; i < value; i++)
            {
                for (int k = 0; k < (value-1)-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 3번
            int sumi = 0;
            int temp = value;
            if (temp % 2 == 0) temp--; // 짝수처리
            for (int i = 0; i < temp; i++)
            {
                for (int k = 0; k < (temp-sumi)/2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= sumi; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i >= temp/2) sumi -= 2; 
                else sumi += 2;
            }
            Console.WriteLine();

            // 4번
            for (int i = 0; i < value; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = (value-i)-1 + (value-i)-2; j > 0; j --)
                {
                    Console.Write(" ");
                }
                if (i != value-1) Console.Write("*");
                Console.WriteLine();
            }

            // 5번
            sumi = value;
            for (int i = 0; i < (value*2); i++)
            {
                for (int j = 0; j < sumi; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < value-sumi; k++)
                {
                    Console.Write("*");
                }
                if (i < value) sumi--;
                else sumi++;
                Console.WriteLine();
            }
        }
    }
}

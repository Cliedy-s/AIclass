using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_05_구구단
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                        int num1 = 9;
                        int num2 = 9;
            */
            /*
                        // 다 찍기
                        for (int i = 1; i <= num1; i++)
                        {
                            for (int j = 2; j <= num2; j++)
                            {
                                Console.Write("{0} * {1} = {2,-2}, ", j, i, i * j);
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        //

                        // 원하는 단 찍기
                        Console.Write(" :: ");
                        int wantDan = int.Parse(Console.ReadLine());
                        num2 = 9;
                        for (int j = 1; j <= num2; j++)
                        {
                            Console.Write("{0} * {1} = {2,-2}, ", wantDan, j, wantDan * j);
                        }
                        Console.ReadLine();
                        //

                        // 원하는 단들 찍기
                        Console.Write(" :: ");
                        int wantDanFirst = int.Parse(Console.ReadLine());
                        Console.Write(" :: ");
                        int wantDanFinal = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= num1; i++)
                        {
                            for (int j = wantDanFirst; j <= wantDanFinal; j++)
                            {
                                Console.Write("{0} * {1} = {2,-2}, ", j, i, i * j);
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        //
            */
/*
            // 3단씩 끊어찍기
            for (int k = 2; k <= 9; k += 3)
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = k; j <= k + 2 && j <= 9; j++)
                    {
                        Console.Write("{0} * {1} = {2, -3}", j, i, j * i);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            //
*/

            // 3단씩 끊어찍기
            for (int k = 0; k <= 6; k += 3)
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = k + 2; j <= k + 4 && j <= 9; j++)
                    {
                        Console.Write("{0} * {1} = {2, -3}", j, i, j * i);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler_003
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.Write(" :: ");
                        long Num = long.Parse(Console.ReadLine());
                        long result = 0;
                        for (long A = Num / 2; A > 0; A--)
                        {
                            if (Num % A == 0) // i가 num의 인수
                            {
                                for (long j = A / 2; j > 0; j--) // 인수가 소수인지 판별
                                {
                                    if (j == 1)
                                    {
                                        result = A;
                                        Console.Write("{0} ",result);
                                        break;
                                    }
                                    if (A % j == 0)
                                        break;
                                }
                            }
                            if (result != 0) // 소인수가 나왔을 때 종료
                                break;
                        }
                        Console.ReadLine();
            */
            /*
                        // 효율적
                        Console.Write(" :: ");
                        long Num = long.Parse(Console.ReadLine());
                        long t = Num, mx = 1;
                        for (long i = 2; i * i <= Num; i++)
                        {
                            if (t % i == 0)
                            {
                                mx = Math.Max(mx, i);
                                while (t % i == 0)
                                    t /= i;
                            }
                        }
                        mx = Math.Max(mx, t);
                        Console.WriteLine(mx);
                        //
            */

            // 재시도
            Console.Write(" :: ");
            long Num = long.Parse(Console.ReadLine());
            long temp = Num;
            long max = 0;

            for (long i = 2; i * i < Num; i++)
            {
                if(temp % i == 0)
                {
                    max = Math.Max(max, i);
                    while (temp % i == 0)
                        temp /= i;
                }
            }
            max = Math.Max(max, temp);
            Console.WriteLine(max);
            //

        }
    }
}

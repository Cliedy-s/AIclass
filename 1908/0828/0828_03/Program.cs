using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
/*
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
*/
/*
            sum = 0;
            for (int i = 100; i > 0; i--)
            {
                sum += i;1`
            }
            Console.WriteLine(sum);
*/
            int sum5 = 0;
            sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                    sum5 += i;
                else
                    continue;
                sum += i;
            }
            Console.WriteLine("{0}, {1}",sum, sum5);
            // while, do while

        }
    }
}

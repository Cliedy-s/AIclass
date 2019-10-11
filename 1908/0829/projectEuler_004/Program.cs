using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler_004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int a, b, c, d, e, f;
                        int x;
                        a = b = c = d = e = f = 0;
                        int max=0;
                        for (int i = 999; i >= 100; i--)
                        {
                            for (int j = 999; j >= 100; j--)
                            {
                                if (i * j / 100000 >= 1)
                                {
                                    x = i * j;
                                    a = x % 10;
                                    b = x % 100 / 10;
                                    c = x % 1000 / 100;
                                    d = x % 10000 / 1000;
                                    e = x % 100000 / 10000;
                                    f = x / 100000;
                                    if (a == f && b == e && c == d)
                                    {
                                        max = Math.Max(max, x);
                                    }
                                }
                            }
                        }
                        Console.WriteLine(max);
            */

            for (int n = 997; n > 100; n--)
            {
                int v = n * 1000 + (n / 100) + ((n / 10) % 10) * 10 + (n % 10) * 100;
                for (int i = (v + 998) / 999; i * i <= v; i++)
                {
                    if (v % i == 0)
                    {
                        Console.WriteLine("{0} x {1} = {2}\n", i, v / i, v);
                        break;
                    }
                }
            }
        }
    }
}

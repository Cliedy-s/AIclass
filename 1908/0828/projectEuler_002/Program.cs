using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, j=2, k=0, sum=0;
            while(i<= 4000000)
            {
                if (i % 2 == 0)
                    sum += i;
                k = i + j;
                i = j;
                j = k;
            }
            Console.WriteLine(sum);

        }
    }
}

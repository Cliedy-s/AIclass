using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_06_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (true)
            {
                int j = 1;
                while (true)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
                    if (++j > 0)
                        break;
                }
                if (++i > 9)
                    break;
            }
        }
    }
}

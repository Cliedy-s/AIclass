using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            recursive(i);

        }

        static int recursive(int n){
            int i;
            if (n == 1)
            {
                return 2;
            }
            else {
                i = (2 * recursive(n - 1)) + 1;
                Console.WriteLine(i);
                return i;
            }
        }
    }
}

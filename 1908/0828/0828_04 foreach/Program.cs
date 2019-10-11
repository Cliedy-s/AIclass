using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_04_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jumsu = new int[5] { 50, 70, 99, 80, 95 };
            int sum = 0;
            
            foreach (var score in jumsu)
            {
                sum += score;
            }

            Console.WriteLine("{0}, {1}", sum, Math.Round(sum/ jumsu.Length*1.0, 2));
        }
    }
}

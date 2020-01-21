using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0114_01_몸풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int v = 0;
            Console.WriteLine("숫자를 엔터와 입력하시고 끝낼려면 q >>");
            while (int.TryParse(Console.ReadLine(), out v))
            {
                list.Add(v);
                list.ForEach((x) => Console.Write(x + " "));
                Console.WriteLine();
            }

            list.Reverse();
            Console.WriteLine("결과 >> ");
            list.ForEach((x) => Console.Write(x + " "));
        }
    }
}

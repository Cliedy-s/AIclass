using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0122_01_몸풀기
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이번주 로또번호 생성
            rotto1().ToList().ForEach(x => Console.Write($"{x,-3}"));
            Console.WriteLine();
            rotto2().ForEach(x => Console.Write($"{x,-3}"));
            Console.WriteLine();
            rotto3().ToList().ForEach(x => Console.Write($"{x, -3}"));

        }
        public static int[] rotto1()
        {
            Random rand = new Random((int)DateTime.Now.Ticks+3);
            //1.
            int[] rotto1 = new int[7];
            for (int i = 0; i < rotto1.Length; i++)
            {
                rotto1[i] = rand.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    while (rotto1[j] == rotto1[i])
                        rotto1[i] = rand.Next(1, 46);
                }
            }
            return rotto1;
        }
        public static List<int> rotto2()
        {
            Random rand = new Random((int)DateTime.Now.Ticks+1);
            ////2.1
            //List<int> rotto2 = new List<int>();
            //while (rotto2.Count <= 7)
            //{
            //    int temp = rand.Next(1, 46);
            //    while (!rotto2.Contains(temp))
            //    {
            //        rotto2.Add(temp);
            //    }
            //}
            //return rotto2;

            //2.2
            List<int> table = new List<int>();
            table = Enumerable.Range(1, 46).ToList();
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                int idx = rand.Next(table.Count);
                arr[i] = table[idx];
                table.RemoveAt(idx);
            }
            return arr.ToList();

        }
        public static HashSet<int> rotto3()
        {
            Random rand = new Random((int)DateTime.Now.Ticks+2);
            //3.
            HashSet<int> rotto3 = new HashSet<int>();
            while (rotto3.Count < 7)
            {
                rotto3.Add(rand.Next(1, 46));
            }
            return rotto3;
        }
    }
}

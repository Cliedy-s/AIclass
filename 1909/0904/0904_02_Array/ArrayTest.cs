using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904_02_Array
{
    class ArrayTest
    {
        public static void ReturnArray(int[] p)
        {
            p[0]++;
        }
        static void Main(string[] args) // 안써도 되긴함 strig[] args
        {

            //System.Array.Copy()
            int[,] arr2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("{0,-3}", arr2[i, j]);
                }
                Console.WriteLine();
            }

            int[] arr = new int[3] { 1, 2, 3 };
            int[] arr3 = (int[])arr.Clone();
            Console.WriteLine("호출 전 : {0}", arr[0]);
            ReturnArray(arr3);
            ReturnArray(arr.Clone() as int[]);
            Console.WriteLine("호출 후 : {0}", arr[0]);
            Console.WriteLine("arr3[0] : {0}", arr3[0]);
            Console.WriteLine(arr.Min());

            Console.WriteLine(arr2.GetLowerBound(0));
            Console.WriteLine(arr2.GetUpperBound(0));
            int[] arr4 = new int[5] { 3, 2, 5, 6, 1 };
            Array.Sort(arr4);
            foreach (var i in arr4)
            {
                Console.Write(i);
            }
            Array.Reverse(arr4);
            foreach (var i in arr4)
            {
                Console.Write(i);
            }
        }
    }
}

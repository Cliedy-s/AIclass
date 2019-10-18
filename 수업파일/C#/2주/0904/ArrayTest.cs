using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0904
{
    class ArrayTest
    {
        public static void ReturnArray(int[] p)
        {
            p[0]++;
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[3] { 1, 2, 3 };

            Console.WriteLine("호출 전 : {0}", arr1[0]); //1	
            ReturnArray((int[])arr1.Clone());
            Console.WriteLine("호출 후 : {0}", arr1[0]); //1


            Console.WriteLine("\n");


            int[] arr2 = new int[3] { 1, 2, 3 };

            Console.WriteLine("호출 전 : {0}", arr2[0]); //1			
            ReturnArray((int[])arr2.Clone());
            Console.WriteLine("호출 후 : {0}", arr2[0]); //1
        }
    }
}

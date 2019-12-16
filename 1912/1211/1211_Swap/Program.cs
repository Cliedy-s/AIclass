using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1211_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            Swap(ref a, ref b);
            Console.WriteLine($"{a}, {b}");
            int[] arr = new int[2] { 5, 2 };
            Swap(arr);
            Console.WriteLine($"{arr[0]}, {arr[1]}");
        }
        static void Swap(int[] arr)
        {
            int temp = arr[0];
            arr[0] = arr[1];
            arr[1] = temp;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

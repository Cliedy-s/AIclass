using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0830_01_MyCalculator;

namespace _0830_01_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3));
            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3, 4, 5));
            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            // params x
            int[][] intArr = new int[1][];
            intArr[0] = new int[] { 1, 2, 3 };
            Console.WriteLine("Sum : {0}", calc.SumNoParams(intArr[0]));
            intArr[0] = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum : {0}", calc.SumNoParams(intArr[0]));
            intArr[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum : {0}", calc.SumNoParams(intArr[0]));


            Console.WriteLine("Sum : {0}", calc.SumAll(10));
            Console.WriteLine("Sum : {0}", calc.SumAll(5, 10));
            Console.WriteLine("Sum : {0}", calc.SumAll(-5));
        }
    }
}

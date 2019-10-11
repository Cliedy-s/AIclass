using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0830
{

    class Program
    {
        static void Main(string[] args)
        {
           MyCalculator.Calculator calc = new MyCalculator.Calculator();

            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3));
            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3, 4, 5));
            Console.WriteLine("Sum : {0}", calc.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            Console.WriteLine("Sum : {0}", calc.SumAll(10));
            Console.WriteLine("Sum : {0}", calc.SumAll(5, 10));
        }
    }
}

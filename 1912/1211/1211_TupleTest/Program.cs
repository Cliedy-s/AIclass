using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1211_TupleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTuple m = CalcByClass(3, 5);
            Console.WriteLine($"{m.Plus}, {m.Multiple}, {m.Minus}, {m.Devide}");

            (int Plus, int Minus, int Multiple, double Devide) tuple = CalcByTuple1(3, 5);
            Console.WriteLine($"{tuple.Plus} {tuple.Minus} {tuple.Multiple} {tuple.Devide}");

            Tuple<int, int, int, double> tuple2 = CalcByTuple2(3, 5);
            Console.WriteLine($"{tuple2.Item1} {tuple2.Item2} {tuple2.Item3} {tuple2.Item4}");


        }
        static (int, int, int, double) CalcByTuple1(int a, int b)
        {
            return (a + b, a - b, a * b, a / b * 1.0);
        }
        static Tuple<int, int, int, double> CalcByTuple2(int a, int b)
        {
            return Tuple.Create(a + b, a - b, a * b, a / b * 1.0);
        }
        static MyTuple CalcByClass(int a, int b)
        {
            return new MyTuple {Plus = a+b, Devide = a/b*1.0, Minus = a-b, Multiple = a*b };
        }
    }
    class MyTuple
    {
        public int Plus { get; set; }
        public int Minus { get; set; }
        public int Multiple { get; set; }
        public double Devide { get; set; }
    }
}

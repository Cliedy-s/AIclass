using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0917_02_Generics
{
    #region original
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
    #endregion

    // Generic Class
    class Calculator<T> where T: struct // T : 뭘 써도됨, where T:Person 가능
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da + db;
        }
        public T Minus(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da - db;
        }
        public T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da * db;
        }
        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da / db;
        }
    }
    //

    class CalculatorProgram
    {
        static void Main(string[] args)
        {
            Calculator<int> icalculator = new Calculator<int>();
            Console.WriteLine(icalculator.Add(2, 5));
            Calculator<double> dcalculator = new Calculator<double>();
            Console.WriteLine(dcalculator.Add(2.56, 5.12));

            // Calculator<Person> cp = new Calculator<Person>(); // struct : 값형식, class : 참조형식
        }
    }
    class Person
    {

    }
}

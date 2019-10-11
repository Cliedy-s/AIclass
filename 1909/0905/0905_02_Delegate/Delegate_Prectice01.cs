using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    public class Mathematics
    {
        delegate int CalcDelegate(int x, int y);

        static int Add(int x, int y) { return x + y; }
        static int Substract(int x, int y) { return x - y; }
        static int Multiply(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return x / y; }

        CalcDelegate[] methods;

        public Mathematics()
        {
            methods = new CalcDelegate[] { Mathematics.Add, Mathematics.Substract,Mathematics.Multiply,Mathematics.Divide };
        }

        public void Calculate(char opCode, int operand1, int operand2)
        {
            switch (opCode)
            {
                case '+':
                    Console.WriteLine("{0}", methods[0](operand1, operand2)) ;
                    break;
                case '-':
                    Console.WriteLine("{0}", methods[1](operand1, operand2));
                    break;
                case '*':
                    Console.WriteLine("{0}", methods[2](operand1, operand2));
                    break;
                case '/':
                    Console.WriteLine("{0}", methods[3](operand1, operand2));
                    break;
            }
        }
    }
    class Delegate_Prectice01
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        static void Main(string[] args) {
            Mathematics math = new Mathematics();
            WorkDelegate work = math.Calculate;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('/', 10, 5);
        }
    }
}

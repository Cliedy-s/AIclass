using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0909_prectice_EventPrimeNumber
{
    class CallbackArg { }
    class PrimeCallbackArg : CallbackArg
    {
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    class PrimeGenerator
    {
        public delegate void PrimeDelegate(object sender, CallbackArg arg);

        public PrimeDelegate callbacks;

        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if(IsPrime(i) == true && callbacks != null)
                {
                    callbacks(this, new PrimeCallbackArg(i));
                }
            }
        }

        public bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0) return candidate == 2;
            for (int i = 3; (i*i) <= candidate; i+=2)
            {
                if ((candidate % i) == 0) return false;
            }
            return candidate != 1;
        }
    }

    class Program_01
    {
        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime+", ");
        }
        static int Sum;
        static void SumPrime(object sender, CallbackArg arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            gen.callbacks += PrintPrime;
            gen.callbacks += SumPrime;

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            gen.callbacks -= SumPrime;
            gen.Run(15);
        }
    }
}

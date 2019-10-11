using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0909_prectice_EventPrimeNumber
{
    class PrimeCallbackArg02 : EventArgs
    {
        public int Prime;
        public PrimeCallbackArg02(int prime)
        {
            this.Prime = prime;
        }
    }

    class PrimeGenerator02
    {
        public event EventHandler PrimeGenerated02;
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if(IsPrime(i) == true && PrimeGenerated02 != null)
                {
                    PrimeGenerated02(this, new PrimeCallbackArg02(i));
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

    class Program_02
    {
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg02).Prime+", ");
        }

        static int Sum;
        static void SumPrime(object sender, EventArgs arg)
        {
            Sum += (arg as PrimeCallbackArg02).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator02 gen = new PrimeGenerator02();

            gen.PrimeGenerated02 += PrintPrime;
            gen.PrimeGenerated02 += SumPrime;

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            gen.PrimeGenerated02 -= SumPrime;
            gen.Run(15);
        }
    }
}

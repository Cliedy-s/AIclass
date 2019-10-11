using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904_03_숙제
{
    class Program
    {
        static void Main(string[] args)
        {
            Kilogram kil = new Kilogram(5);
            Console.WriteLine(kil);

            Gram gram = new Gram(3000);
            Console.WriteLine(gram);

            Kilogram gramToKil = gram;
            Console.WriteLine("Gram To Killogram : {0} => {1}",gram, gramToKil);

            Gram kilToGram = kil;
            Console.WriteLine("Kilogram To Gram : {0} => {1}", kil, kilToGram);
        }
    }
    
    public class Kilogram
    {
        double mass;
        public Kilogram(double value)
        {
            this.mass = value;
        }
        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString()
        {
            return mass+"kg";
        }
        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }

        static public implicit operator Gram(Kilogram kilogram)
        {
            return new Gram(kilogram.mass * 1000.0);
        }
    }

    public class Gram
    {
        double mass;
        public Gram(double value)
        {
            this.mass = value;
        }

        public override string ToString()
        {
            return mass + "g";
        }

        static public implicit operator Kilogram(Gram gram)
        {
            return new Kilogram(gram.mass * 0.001);
        }
    }
}

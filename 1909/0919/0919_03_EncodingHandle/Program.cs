using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_03_EncodingHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello 안녕";

            Console.WriteLine("기본문장 : {0}", str);
            Console.WriteLine();

            byte[] results1 = Encoding.UTF8.GetBytes(str);
            Console.WriteLine("UTF -8");
            Console.WriteLine(PrintByteArr(results1));
            Console.WriteLine(Encoding.UTF8.GetString(results1));
            Console.WriteLine();

            //ASCII
            byte[] results2 = Encoding.ASCII.GetBytes(str);
            Console.WriteLine("ASCII");
            Console.WriteLine(PrintByteArr(results2));
            Console.WriteLine(Encoding.ASCII.GetString(results2));
            Console.WriteLine();

            //Default
            byte[] results3 = Encoding.Default.GetBytes(str);
            Console.WriteLine("Default");
            Console.WriteLine(PrintByteArr(results3));
            Console.WriteLine(Encoding.Default.GetString(results3));
            Console.WriteLine();

            Console.WriteLine("EncodingName : {0}", Encoding.Default.EncodingName);
            Console.WriteLine("BodyName : {0}", Encoding.Default.BodyName);
            Console.WriteLine("CodePage : {0}", Encoding.Default.CodePage);
            Console.WriteLine();
            //
            byte[] results4= Encoding.UTF8.GetBytes(str);
            Console.WriteLine("PrintByteArrIEnumerable");
            IEnumerable<string> IEstr = PrintByteArrIEnumerable(results4);
            Array.ForEach<string>(IEstr.ToArray(), (elem) => Console.Write(elem+", ") );
            Console.WriteLine(Encoding.UTF8.GetString(results4));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static IEnumerable<string> PrintByteArrIEnumerable(byte[] bytes)
        {
            foreach (var i in bytes)
            {
                yield return i.ToString();
            }
        }

        static string PrintByteArr(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte i in bytes)
            {
                sb.Append(i.ToString());
                sb.Append(",");
            }
            return sb.ToString().TrimEnd(',');
        }
    }
}

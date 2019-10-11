using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_06_escape_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            char cTab = '\t';
            char cLIneFeed = '\n';
            char cCarrageReturn = '\r';
            char cBackSpace = '\b';
            char cBackSlash = '\\';
            char cSingleQuote = '\'';
            char cDoubleQuote = '\"';

            Console.WriteLine("TAB : >{0}<", cTab);
            Console.WriteLine("LIneFeed : >{0}<", cLIneFeed);
            Console.WriteLine("CarrageReturn : >{0}<", cCarrageReturn); // 캐리지리턴? : 해당 라인의 제일 앞
            Console.WriteLine("BackSpace : >{0}<", cBackSpace);
            Console.WriteLine("BackSlash : >{0}<", cBackSlash);
            Console.WriteLine("SingleQuote : >{0}<", cSingleQuote);
            Console.WriteLine("DoubleQuote : >{0}<", cDoubleQuote);
            
            //
            string a = "hello";
            string b = a;

            a = "hello2";

            Console.WriteLine(a);
            Console.WriteLine(b);
            //

        }
    }
}

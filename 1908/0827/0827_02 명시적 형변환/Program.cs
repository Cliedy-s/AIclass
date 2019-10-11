using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_02_명시적_형변환
{
    class Program
    {
        static void Main(string[] args)
        {
            //명시적 형변환 / 암시적 형변환
            short sVal = 10;
            int iVal = 32768; //Int32.MaxValue;

            //iVal = sVal; // 작 -> 큰 (암시o)
            //Console.WriteLine(iVal);
            try
            {
                checked
                { //check => 오버플로우시 에러를 일으킴
                    sVal = (short)iVal; // 큰 -> 작 (암시x) =>명시적 형변환 필요 -32768
                }
                Console.WriteLine(sVal);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            //
        }
    }
}


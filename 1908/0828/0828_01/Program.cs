using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");
            int iNum = int.Parse(Console.ReadLine()); // System.Convert.ToInt32()
            string result1 = String.Empty, result2 = String.Empty;
            /*
                         if (iNum > 0)
                             result = "양수";
                         else if (iNum == 0)
                             result = "0";
                         else
                             result = "음수";
                         Console.WriteLine(result);
                         if (iNum % 2 == 0)
                             result = "짝수";
                         else
                             result = "홀수";
             */
            /*
            result1 = (iNum > 0) ? "양수" : ((iNum == 0) ? "0" : "음수");
            result2 = (iNum == 0) ? "0" : ((iNum %2== 0) ? "짝수" : "홀수");
             */
            /*
            if (iNum > 0)
            {
                result1 = "양수";
                if (iNum % 2 == 0)
                    result2 = "짝수";
                else
                    result2 = "홀수";
            }
            else if (iNum < 0)
            {
                result1 = "음수";
                if (iNum % 2 == 0)
                    result2 = "짝수";
                else
                    result2 = "홀수";
            }
            else
            {
                result1 = "0";
            }
            if (result1 == "0")
                Console.WriteLine(result1);
            else
                Console.WriteLine("{0} 그리고 {1}", result1, result2);
*/

            result1 = "양수";
            result2 = "짝수";

            if (iNum % 2 == 1)
                    result2 = "홀수";
            if (iNum < 0)
                result1 = "음수";
            else if (iNum == 0)
                result1 = "0";

            if (result1 == "0")
                Console.WriteLine(result1);
            else
                Console.WriteLine("{0} 그리고 {1}", result1, result2);


        }
    }
}

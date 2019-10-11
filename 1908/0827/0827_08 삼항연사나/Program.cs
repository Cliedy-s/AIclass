using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_08_삼항연사나
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int value = 5;
            string result;

            if( value %2 == 0)
            {
                result = "짝수";
            }
            else
            {
                result = "홀수";
            }
            Console.WriteLine(result);
            */
            // 삼항 연산자
            int value = 5;
            string result = (value % 2 == 0) ? "짝수" : ((value ==0) ? "0" : "홀수");

            switch (value %2)
            {
                case 1:
                    result = "홀";
                    break;
                case 0:
                    result = "짝";
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);

            Console.WriteLine("계속 하시겠습니까? (Y/N)");
            string str = Console.ReadLine();
            switch (str)
            {
                case "y": case "Y":
                    result = "계속";
                    break;
                case "n": case "N":
                    result = "종료";
                    break;
                default:
                    result = "다시 입력하세요.";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_02_bmi계산
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            
            // 체중, 키 입력
            Console.Write("키(cm) : ");
            double height = double.Parse(Console.ReadLine())/100;
            Console.Write("몸무게(kg) : ");
            int weight = int.Parse(Console.ReadLine());

            // 지수 계산
            double dBmi = weight / (height * height);

            // 조건 체크
            if (dBmi <= 18.5)
                result = "저체중";
            else if (dBmi <= 23)
                result = "정상";
            else if (dBmi <= 25)
                result = "과체중";
            else if (dBmi <= 30)
                result = "비만";
            else
                result = "고도비만";

            //출력
            Console.WriteLine("당신의 bmi지수는 {0:0.0000}이고, {1}입니다", dBmi, result);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_07_파일추가하기
{
    class RandomTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Test");

            Random rand = new Random();

            /*
                        int number = rand.Next(); // int내 전체 ㅇㅇ
                        Console.WriteLine(number);

                        int number2 = rand.Next(10); // 0~9
                        Console.WriteLine(number2);

                        int number3 = rand.Next(6, 12); // 6~11
                        Console.WriteLine(number3);

                        double number4 = rand.NextDouble(); // 0~1
                        Console.WriteLine(number4);
            */

            //
            int[] rottery = new int[6];
            int num = 0;
            num = rand.Next(1, 7);

            for (int i = 0; i < rottery.Length; i++) // 0~5
            {
                for (int j = 0; j < i; j++) // 0~i
                {
                    if (rottery[j] == num)
                    {
                        num = rand.Next(1, 7);
                        j = -1; // 이후 j++를 함
                    }
                }
                rottery[i] = num;
            }
            foreach (int i in rottery)
            {
                Console.WriteLine("{0} ", i);
            }
            //

            //
            Byte[] bArr = new byte[6];
            int[] iArr = new int[6];
            rand.NextBytes(bArr); // 중복 값 x

            for (int i = 0; i < bArr.Length; i++)
            {
                iArr[i] = (int)bArr[i];
                iArr[i] = (iArr[i] % 6) + 1; // 중복 값이 생김
            }

            foreach (byte i in iArr)
            {
                Console.Write("{0, -3} ", i);
            }
            //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0828_07_파일추가하기
{
    class ArrayUniqueNum
    {
        static void Main(string[] args)
        {
            int[] rottery = new int[3];
            Random rand = new Random();
            rottery[0] = rand.Next(10);
            int temp = rand.Next(0, 10);
            int cnt = 1;
            bool isUnique; // 해당 값이 존재하지 않는 값인지 확인

            while (cnt < 3)
            {
                temp = rand.Next(0, 10);
                isUnique = true; // 초기값

                // 처음부터 넣은 수까지 확인 (cnt => 넣은 수 1,2,3)
                for (int i = 0; i < cnt; i++) 
                {
                    if (rottery[i] == temp) // 해당 값이 존재하면 false
                    {
                        isUnique = false;
                        break;
                    }
                }
                //

                // true > 해당 값이 존재하지 않을 경우
                if (isUnique) 
                {
                    rottery[cnt] = temp;
                    cnt++;
                }
                //
            }
            foreach (var a in rottery)
            {
                Console.Write("{0} ", a);
            }
        }
    }
}

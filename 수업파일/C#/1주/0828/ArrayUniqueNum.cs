using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0828
{
    class ArrayUniqueNum
    {
        static void Main(string[] args)
        {
            int[] su = new int[3];
            Random rnd = new Random();

            su[0] = rnd.Next(0, 10);

            int cnt = 1;
            bool isUnique;

            while (cnt < 3)
            {
                int temp = rnd.Next(0, 10);
                isUnique = true;

                for (int i = 0; i < cnt; i++)
                {
                    if (su[i] == temp)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    su[cnt] = temp;
                    cnt++;
                }
            }

            foreach (int num in su)
            {
                Console.Write("{0}  ", num);
            }
        }
    }
}

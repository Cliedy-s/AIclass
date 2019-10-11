using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    class SortObject06
    {
        public delegate bool CompareObjectDelegate(System.Object arg1, System.Object arg2);
        Object[] things = null;

        public SortObject06(Object[] things)
        {
            this.things = things;
        }

        public void Sort(CompareObjectDelegate compareObjectMethod)
        {
            Object temp;
            for (int i = 0; i < things.Length; i++)
            {
                int lowPos = i;
                for (int j = i + 1; j < things.Length; j++)
                {
                    if (compareObjectMethod(things[j], things[lowPos]))
                    {
                        lowPos = j;
                    }
                }
                temp = things[lowPos];
                things[lowPos] = things[i];
                things[i] = temp;
            }
        }
        public void Display()
        {
            for (int i = 0; i < things.Length; i++)
            {
                Console.Write(things[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{

    class SortObject05
    {
        Person[] men = null;

        public SortObject05(Person[] men)
        {
            this.men = men;
        }

        public void Sort()
        {
            Person temp;
            for (int i = 0; i < men.Length; i++)
            {
                int lowPos = i;
                for (int j = i + 1; j < men.Length; j++)
                {
                    if (men[j].Age<  men[lowPos].Age)
                    {
                        lowPos = j;
                    }
                }
                temp = men[lowPos];
                men[lowPos] = men[i];
                men[i] = temp;
            }
        }
        public void Display()
        {
            for (int i = 0; i < men.Length; i++)
            {
                Console.Write(men[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

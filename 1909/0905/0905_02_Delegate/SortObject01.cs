using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    class SortObject01
    {
        int[] numbers = null;
        public SortObject01(int[] numbers)
        {
            this.numbers = numbers;
        }
        public void Sort()
        {
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[lowPos])
                    {
                        lowPos = j;
                    }
                }
                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }
        public void Display()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

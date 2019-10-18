using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp09052
{
    class SortObject
    {
        int[] numbers;

        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void Sort(bool ascending)
        {
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                int lowPos = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (ascending)
                    {
                        if (numbers[j] < numbers[lowPos])
                        {
                            lowPos = j;
                        }
                    }
                    else
                    {
                        if (numbers[j] > numbers[lowPos])
                        {
                            lowPos = j;
                        }
                    }
                }
                // 교환
                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }
    }

    class ProgramSort
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };
            SortObject so = new SortObject(intArray);
            so.Sort(false);
            so.Display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    // https://hsp1116.tistory.com/33 :: 정렬 종류
    class ObjectCompare
    {
        Dog[] array;

        public delegate bool ObjectCompareDelegate(object arg1, object arg2);
        
        public ObjectCompare(Dog[] array)
        {
            this.array = array;

            
        }
        public void BubbleSort(ObjectCompareDelegate objectCompare)
        {
            Dog temp = null;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (objectCompare(array[j], array[j+1]))//array[j] < array[j + 1]
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void Print()
        {
            foreach (var i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        //TODO- 안녕

    }
}

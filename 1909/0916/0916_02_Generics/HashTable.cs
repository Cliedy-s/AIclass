using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0916_03_HashTable
{
    class HashTableProgram
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "홍길동");
            ht.Add(2, "김길동");
            ht.Add(3, "박길동");
            ht.Add(4, "이길동");
            ht.Add(5, "최길동");
            // ht.Add(5, "정길동"); // Key 중복시 ArgumentException

            foreach (object key in ht.Keys) // 숫자키 : 거꾸로나옴, string : 순서대로..? => 넣은 순으로 안나올 수 있음
            {
                Console.Write(ht[key] + " ");
            }
            Console.WriteLine();
            foreach (object value in ht.Values)
            {
                Console.Write(value.ToString() + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < 6; i++)
            {
                Console.Write(ht[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

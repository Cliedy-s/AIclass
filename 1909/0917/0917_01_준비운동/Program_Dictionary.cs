using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0917_01_준비운동
{
    class Program_Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ht = new Dictionary<string, int>();
            //Hashtable ht = new Hashtable();

            ht.Add("김길동", 30);
            ht.Add("홍길동", 100);
            ht.Add("박길동", 50);
            ht.Add("신길동", 20);
            ht.Add("서길동", 70);
            ht.Add("창길동", 10);
            ht.Add("거길동", 80); // 키값이 중복되면 딕셔너리 - 덮어쓰기, 해시테이블 - 에러
            // ht.Add("거길동", 80); // 중복x
            ht["미길동"] = 100; // 미길동이 존재? : 100으로 덮어쓰기, 미길동 존재x? : 새로 집어넣기

            foreach (var key in ht.Keys)
            {
                Console.WriteLine("{0} :: {1} ", key, ht[key]);
            }

            if (ht.ContainsKey("홍길동")) // ht.Contains("홍길동") , ht["홍길동"] != null
                Console.WriteLine("홍길동님의 점수 : {0}", ht["홍길동"]);
            else
                Console.WriteLine("입력된 학생이 아닙니다.");

            /*
                        // 음..
                        ArrayList ht_al = new ArrayList(ht.Values);
                        ht_al.Sort();
                        ht_al.Reverse();
                        // ...

                        SortedList sortedList = new SortedList(ht);
                        foreach (DictionaryEntry data in sortedList)
                            Console.WriteLine("{0} :: {1} ", data.Key, data.Value);
            */
        }
    }
}

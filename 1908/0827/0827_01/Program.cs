using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 포멧스트링
            int age = 22;
            string name = "신소연";
            string phone = "010-6305-5237";

            Console.WriteLine("이름 : " + name + ", 나이 : " + age + ", 전화번호 : " + phone); // int(age) -> string(writeline) 속도x
                                                                                       //
            Console.WriteLine("이름 : {0}, 나이 : {1}, 전화번호 : {2}", name, age, phone); // 형변환x 
            Console.WriteLine("short minshort : {0}, maxshort : {1}", Int16.MinValue, Int16.MaxValue);
            //
        }
    }
}

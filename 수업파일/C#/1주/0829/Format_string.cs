using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0829
{
    class Format_string
    {
        static void Main(string[] args)
        {
            //매개변수 지정자 (Index는 0부터)
            string primes = String.Format("10이하 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            //primes = String.Format("10이하 소수: {2}, {1}, {0}, {3}",  2, 3, 5, 7); 
            //primes = String.Format("10이하 소수: {0}, {1}, {2}", 2, 3, 5, 7);
            //primes = String.Format("10이하 소수: {0}, {1}, {2}, {3}, {4}", 2, 3, 5, 7); //오류발생
            Console.WriteLine(primes);

            //동일한 숫자값을 여러가지로 지정 (16진수, 지수, 숫자 형식)
            string multiple = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(multiple);

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };

            //기본서식의 필드 너비를 표시(양수:오른쪽 정렬, 음수:왼쪽 정렬 ,  소수점자리수:N)
            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

            //Format String
            Console.WriteLine("{0:yyyy-MM-dd}", DateTime.Now);
            Console.WriteLine("{0:MMMM dddd}", DateTime.Now);

            int MyInt = 100;
            Console.WriteLine("{0:C}", MyInt);

            string myName = "Fred";
            Console.WriteLine(String.Format("Name = {0}, hours = {1:hh}, minutes = {1:mm}", myName, DateTime.Now));
        }
    }
}

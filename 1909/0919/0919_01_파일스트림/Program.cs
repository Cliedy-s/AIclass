using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0919_01_파일스트림
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(System.DateTime.Now.ToString()); // 시차가 적용된 현재시간
            //Console.WriteLine(System.DateTime.UtcNow.ToString());
            //TimeSpan left = new DateTime(2019, 12, 25) - DateTime.Now;

            DateTime to = DateTime.Now.AddMonths(3);
            DateTime from = DateTime.Now.AddMonths(-1); // 한달전  :  AddMonths
            // DateTime endOfMonth = new DateTime(to.Year, to.Month+1, 1).AddDays(-1); // 연말에 에러
            DateTime endOfMont2 = to.AddMonths(1).AddDays(-to.Day);

            int date = (DateTime.Now - new DateTime(1998, 09, 13)).Days;
            // var days = new DateTime { Year = 2019, Month = 12, Day = 30 }; // Property가 public이 아님
            var person = new Person { A = 1, B = 2 }; // 객체 초기화

            Console.WriteLine("{0} ~ {1} ~ {2} \n태어난지 {3}일째", from.ToShortDateString(), to.ToShortDateString(), endOfMont2.ToShortDateString(), date);
            TimeSpan ts = DateTime.Now - new DateTime(1998, 09, 13);
        }
    }

    class Person
    {
        int a;
        int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
    }
}

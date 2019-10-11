using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0916_01_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumbers;
            string name, phone, date;

            Console.Write("몇 명을 입력하시겠습니까? :: ");
            bool isSuccess = int.TryParse(Console.ReadLine().Trim(), out peopleNumbers);
            Person02[] people = new Person02[peopleNumbers];

            if (!isSuccess)
            {
                Console.WriteLine("다시 입력해 주세요");
                return;
            }
            name = phone = string.Empty;
            //

            for (int i = 0; i < peopleNumbers; i++)
            {
                Console.Write("이름 :: ");
                name = Console.ReadLine();
                Console.Write("전화번호 :: ");
                phone = Console.ReadLine();
                Console.Write("생일 :: ");
                date = Console.ReadLine();

                people[i] = new Person02(name, phone, date);
            }

            foreach (var i in people)
            {
                Console.WriteLine(i.ToString()); 
            }
            Console.ReadLine();


            //GetLowerBound, GetUpperBound

            int[,,] arr= new int[5, 3, 6];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", arr.GetLength(i));
                Console.WriteLine("{0} : {1}", arr.GetLowerBound(i), arr.GetUpperBound(i) );
            }
        }
    }
    struct Person02 // 메인이 끝날 때까지 살아있음?
    {
        public string name, phone, date;
        public Person02(string name, string phone, string date)
        {
            this.name = name;
            this.phone = phone;
            this.date = date;
        }
        public override string ToString()
        {
            return string.Format("{0} :: {1} : {2}", name, phone, date);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _0916_01_준비운동
{
    class GenericProgram
    {
        static void Main(string[] args)
        {
            string name, phone, date;
            string[] namePhoneDate = new string[3];
            /*
                        //ArrayList
                        ArrayList arrlist = new ArrayList();
                        name = phone = string.Empty;

                        while (true)
                        {
                            name = phone = date = string.Empty;
                            Console.Write("이름 :: ");
                            name = Console.ReadLine();
                            Console.Write("전화번호 :: ");
                            phone = Console.ReadLine();
                            Console.Write("생일 :: ");
                            date = Console.ReadLine();

                            arrlist.Add(new Person(name, phone, date));

                            Console.Write("계속 입력 하시겠습니까? (y/n) ::");
                            if (Console.ReadLine().Trim().ToUpper() != "Y") break;

                        }

                        foreach (object i in arrlist)
                        {
                            Console.WriteLine(i.ToString());
                        }
            */

            // Generics
            List<Person> list = new List<Person>();
            name = phone = string.Empty;
            Person pSearch = null;

            while (true)
            {
                name = phone = date = string.Empty;
                Console.Write("이름 :: ");
                name = Console.ReadLine();
                Console.Write("전화번호 :: ");
                phone = Console.ReadLine();
                Console.Write("생일 :: ");
                date = Console.ReadLine();

                list.Add(new Person(name, phone, date));

                Console.Write("계속 입력 하시겠습니까? (y/n) ::");
                if (Console.ReadLine().Trim().ToUpper() != "Y") break;

            }

            foreach (Person i in list)
            {
                if(i.Name == "홍길동")
                {
                    pSearch = i;
                }
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("검색값 : {0} , {1}번째에 있습니다.", pSearch.ToString(), list.IndexOf(pSearch));

            /*
                         //GetLowerBound, GetUpperBound
                        int[,,] arr = new int[5, 3, 6];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("{0}", arr.GetLength(i));
                            Console.WriteLine("{0} : {1}", arr.GetLowerBound(i), arr.GetUpperBound(i));
                        }
            */

        }
    }
    class Person
    {
        string name, phone, date;

        public Person(string name, string phone, string date)
        {
            this.Name = name;
            this.Phone = phone;
            this.Date = date;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Date { get => date; set => date = value; }

        public override string ToString()
        {
            return string.Format("{0} :: {1} : {2}", Name, Phone, Date);
        }
    }

}

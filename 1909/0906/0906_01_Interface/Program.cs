using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace _0906_01_Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Array.Sort(intArray, new IntegerCompare());
            foreach (int item in intArray)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();

            Person[] personArray = new Person[] { new Person(60, "가"), new Person(35, "나"), new Person(10, "다"), new Person(70, "라") };
            Array.Sort(personArray, new PersonCompare());
            foreach (var person in personArray)
            {
                Console.Write(person +" ");
            }
            Console.WriteLine();

            Person person1 = new Person(30,"신소연");
            string[] petlist = new string[] { "초코","코숏","루루"};
            person1.PetList = petlist;
        }

    }

    class IntegerCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            // IComparer.Compare( int[i], int[j]);
            int xValue = (int)x;
            int yValue = (int)y;
            if (xValue < yValue) return -1;
            else if (xValue == yValue) return 0;
            else  return 1; //if (xValue < yValue)
        }
    }

    class PersonCompare : IComparer
    {
        public int Compare(object x, object y) // ascending, descending 구분 x
        {
            Person px = x as Person;
            Person py = y as Person;

            if (px.Age < py.Age) return -1;
            else if (px.Age == py.Age) return 0;
            else return 1;
        }
    }
    class Person : IEnumerable
    {
        public int Age { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string[] PetList { get; set; } = null;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} :: {1}", Name, Age); ;
        }

        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator();
        }

        public class PersonEnumerator : IEnumerator
        {
            int pos = -2;
            int lenght = 0;
            object[] list;

            public object Current => list[pos];


            public bool MoveNext()
            {
                if (pos >= lenght - 1) return false;
                pos++;
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }
        }
    }
}

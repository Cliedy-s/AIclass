using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0910_01_IEnumerable
{
    class EnumerableProgram02
    {
        static void Main(string[] args)
        {
            PersonArrayList pal = new PersonArrayList(new Person[]{
                new Person("홍길동",20),
                new Person("김길동",30),
                new Person("박길동",15),
                new Person("신길동",90),
            });

            foreach (Person p in pal)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
    }

    class PersonArrayList : IEnumerable
    {
        Person[] people;

        public PersonArrayList(Person[] people)
        {
            this.people = people;
        }

        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(people);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonEnumerator(people);
        }

        class PersonEnumerator : IEnumerator
        {
            int pos = 0;
            int length = 0;
            object[] personlist;

            public PersonEnumerator(Person[] people)
            {
                this.personlist = people;
                this.pos = people.Length;
                this.length = people.Length;
            }

            public Person Current => personlist[pos] as Person; 

            object IEnumerator.Current => personlist[pos];

            public bool MoveNext()
            {
                if (pos <= 0) return false;
                pos--;
                return true;
            }

            public void Reset()
            {
                pos = length;
            }
        }
    }
}

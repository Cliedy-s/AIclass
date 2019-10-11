using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902_03_static
{
/*
    class Prectice_static
    {
        static public void Main(string[] args)
        {
            Person.p._Name = "Falling away from me now";
            Console.WriteLine(Person.p._Name);
        }
    }
    class Person
    {
        static public Person p = new Person("Mr. RainDrop");
        string _name = string.Empty;
        private Person(string _name) { this._name = _name; }
        public string _Name
        {
            get { return _name; }
            set { this._name = value; }
        }
    }
*/
    class Prectice_static
    {
        static public void Main(string[] args)
        {
            Person p1 = new Person("");
            Person p2 = new Person("");
        }
    }
    class Person
    {
        public Person(string a)
        {
            Console.WriteLine("public Person");
        }
        static Person()
        {
            Console.WriteLine("static Person");
        }
    }

}

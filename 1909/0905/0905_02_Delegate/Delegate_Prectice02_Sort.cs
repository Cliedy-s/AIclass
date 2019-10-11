using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_02_Delegate
{
    class Delegate_Prectice02_Sort
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 4, 1, 0, 3 };

            Console.WriteLine("so1===");
            SortObject01 so = new SortObject01(intArray);
            so.Sort();
            so.Display();

            Console.WriteLine("so2===");
            SortObject02 so2 = new SortObject02(intArray);
            so2.Sort();
            so2.Display();

            Console.WriteLine("so3===");
            SortObject03 so3 = new SortObject03(intArray);
            so3.Sort(true);
            so3.Display();
            so3.Sort(false);
            so3.Display();

            Console.WriteLine("so4===");
            intArray = new int[] { 5, 2, 4, 1, 0, 3 };
            SortObject04 so4 = new SortObject04(intArray);
            so4.Sort(AscendingCompare); // => CompareDelegate compareMethod = AscendingCompare
            so4.Display();
            so4.Sort(DescendingCompare);
            so4.Display();

            Console.WriteLine("so5===");
            Person[] persons = new Person[] { new Person(51, "a"), new Person(37, "b"), new Person(45, "c"), new Person(62, "d") };
            SortObject05 so5 = new SortObject05(persons);
            so5.Sort();
            so5.Display();

            Console.WriteLine("so6===");
            Person[] personsf2 = new Person[] { new Person(51, "a"), new Person(37, "b"), new Person(45, "c"), new Person(62, "d") };
            SortObject06 so6 = new SortObject06(persons);
            so6.Sort(AscendingCompareF2);
            so6.Display();
            so6.Sort(DecendingCompareF2);
            so6.Display();

            Console.WriteLine("oc===");
            Dog[] dogfoc= new Dog[] { new Dog(51, "cucu"), new Dog(37, "choco"), new Dog(45, "bbobbo"), new Dog(62, "roro") };
            ObjectCompare oc = new ObjectCompare(dogfoc);
            oc.BubbleSort(AscendingDogCompareMethod);
            oc.Print();
            Dog[] dogfoc2 = new Dog[] { new Dog(51, "cucu"), new Dog(37, "choco"), new Dog(45, "bbobbo"), new Dog(62, "roro") };
            ObjectCompare oc2 = new ObjectCompare(dogfoc);
            oc2.BubbleSort(DescendingDogNameCompareMethod);
            oc2.Print();
        }

        public static bool DescendingDogCompareMethod(object arg1, object arg2)
        {
            Dog darg1 = arg1 as Dog;
            Dog darg2 = arg2 as Dog;

            return (darg1.Age < darg2.Age);
        }
        public static bool AscendingDogCompareMethod(object arg1, object arg2)
        {
            Dog darg1 = arg1 as Dog;
            Dog darg2 = arg2 as Dog;

            return (darg1.Age > darg2.Age);
        }
        public static bool DescendingDogNameCompareMethod(object arg1, object arg2)
        {
            Dog darg1 = arg1 as Dog;
            Dog darg2 = arg2 as Dog;

            return darg1.Name.CompareTo(darg2.Name) < 0;
        }
        public static bool AscendingDogNameCompareMethod(object arg1, object arg2)
        {
            Dog darg1 = arg1 as Dog;
            Dog darg2 = arg2 as Dog;

            return darg1.Name.CompareTo(darg2.Name) > 0;
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }

        public static bool AscendingCompareF2(Object arg1, Object arg2)
        {
            Person parg1 = arg1 as Person;
            Person parg2 = arg2 as Person;

            return parg1.Name.CompareTo(parg2.Name) < 0;
        }
        public static bool DecendingCompareF2(Object arg1, Object arg2)
        {
            Person parg1 = arg1 as Person;
            Person parg2 = arg2 as Person;

            return parg1.Name.CompareTo(parg2.Name) > 0;
        }

    }

    class Person
    {
        int age;
        string name;
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }

    class Dog
    {
        int age;
        string name;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public Dog(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + " : " +Age ;
        }
    }
}

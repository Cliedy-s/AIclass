using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0909_02_IndexerTest
{
    class IndexerTest
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass();
            c1[0] = 1024; // 인덱서 사용
            c1[1] = 512; // 인덱서 사용
            // c1.Data[1] = 1; // 프로퍼티 사용

            foreach (var i in c1.Data)
            {
                Console.Write(i + " ");
            }

            Employees emps = new Employees(2);

            emps[0] = new Employee("홍길동");
            emps[1] = new Employee("김개똥");

            Console.WriteLine(emps[0].name);
            Console.WriteLine(emps[1].name);

            emps[0].name = "이순신";
            Console.WriteLine(emps[0].name);

            Console.WriteLine(emps["김개똥"].name); // 오버로딩으로 원하는 배열 값 검색 가능
// #if TYPE_CHECK
#if DEBUG
            Console.WriteLine("타입체크?"); // 속성 - 빌드 - 조건부 컴파일 기호 => 외부에서 들어오는 조건에 따라 다르게 컴파일하고 싶을 때
#endif
            Console.ReadLine();
        }
    }
    class MyClass
    {
        int[] data = new int[10];

        public int[] Data
        {
            get { return data; }
            set { data = value; }
        }

        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }

    // teacher========================================
    public class Employee
    {
        public string name;
        public Employee(string name)
        {
            this.name = name;
        }
    }
    public class Employees
    {
        private Employee[] emps;

        public Employees(int n)
        {
            emps = new Employee[n];
        }

        // 오버로딩 가능
        public Employee this[int i]
        {
            get { return emps[i]; }
            set { emps[i] = value; }
        }
        public object this[object o]
        {
            get { return new object(); }
        }
        public Employee this[string name]
        {
            get
            {
                foreach (Employee e in emps)
                    if (e.name == name)
                        return e;
                return null;
            }
            set
            {
                for (int i = 0; i < emps.Length; ++i)
                {
                    if (emps[i].name == name)
                    {
                        emps[i] = value;
                        return;
                    }
                }
            }
        }
        //

    }
}

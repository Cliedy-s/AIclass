using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0906_01_Interface
{
    interface IMan
    {
        string Name { get; set; }

        void Save();
        void Show();
    }
    interface IPerson : IMan
    {

    }
    class Employee : IPerson
    {
        string name;
        public string Name { get => name; set => name = value; }

        void IMan.Save()
        {
            Console.WriteLine("Save Method");
        }

        void IMan.Show()
        {
            Console.WriteLine("Show Method");
        }
    }
    class InterfaceTest
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "아이린";

            IPerson per1 = emp; // 자동형변환
            per1.Show();
            IMan iman = emp;
            iman.Save();

            // emp.Show(); // 명시하면 해당 인터페이스로만 접근가능
            (emp as IMan).Show(); // => o
        }
    }
}

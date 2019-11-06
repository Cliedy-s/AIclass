using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1106_01_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 1단계 -==========================================================
            List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // 1. foreach문
            List<int> dataEven = new List<int>();
            foreach (var item in data)
            {
                if (item % 2 == 0)
                    dataEven.Add(item);
            }
            foreach (var item in dataEven)
            {
                Debug.WriteLine(item);
            }
            // 2. Linq
            var dataEvenLINQ = from even in data
                               where even %2 ==0
                               orderby even descending
                               select even;

            foreach (var item in dataEvenLINQ)
            {
                Debug.WriteLine(item);
            }
            // 3. lambda
            var dataEvenLambda1 = data.Where((elem) => elem % 2 == 0).ToList();
            var dataEvenLambda2 = data.FindAll((elem) => elem % 2 == 0);
            dataEvenLambda1.ForEach((elem) => Debug.WriteLine(elem));
            foreach (var item in dataEvenLambda2)
            {
                Debug.WriteLine(item);
            }
            // 4. yield
            foryield foryield = new foryield();
            var dataEvenYield = foryield.Next(data).ToList();
            dataEvenYield.ForEach((elem) => Debug.WriteLine(elem));

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 2단계 -==========================================================
            List<Person> people = Person.GetPersons();
            List<MainLanguage> languages = MainLanguage.GetMainLanguages();

        }
    }
    class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return string.Format("{0} : {1} in {2}", Name, Age, Address);
        }
        static public List<Person> GetPersons()
        {
            return new List<Person>() {
                new Person { Name = "Tom", Age =63, Address="Korea" },
                new Person { Name = "Winnie", Age =40, Address="Tibet" },
                new Person { Name = "Anders", Age =47, Address="Sudan" },
                new Person { Name = "Hans", Age =25, Address="Tibet" },
                new Person { Name = "Eureka", Age =32, Address="Sudan" },
                new Person { Name = "Hawk", Age =15, Address="Korea" },
            };
        }
    }
    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
        static public List<MainLanguage> GetMainLanguages()
        {
            return new List<MainLanguage>() {
                new MainLanguage { Name = "Anders", Language="Delphi" },
                new MainLanguage { Name = "Anders", Language="C#" },
                new MainLanguage { Name = "Tom", Language="Borland C++" },
                new MainLanguage { Name = "Hans", Language="Visual C++" },
                new MainLanguage { Name = "Winnie", Language="R" },
            };
        }
    }
    class foryield 
    {
        static public IEnumerable<int> Next(List<int> list)
        {
            foreach (var item in list)
            {
                if(item %2==0)
                    yield return item;
            }
        }
    }
}

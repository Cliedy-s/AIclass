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
        private void Form1_Load(object sender, EventArgs e)
        {
            people = Person.GetPersons();
            languages = MainLanguage.GetMainLanguages();
        }

        List<Person> people;
        List<MainLanguage> languages;
        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
            dataEvenYield.ForEach((elem) => listBox1.Items.Add(elem));

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 이름만 출력-==========================================================
            IEnumerable<string> query = from person in people
                        select person.Name;
            query.ToList().ForEach((elem) => listBox1.Items.Add(elem));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 새로운 객체 생성
            IEnumerable<Person> query = from person in people
                        select new Person() { Name = person.Name, Age = person.Age, Address = person.Address }; // Person
            var query02 = from person in people
                                        select new { person.Name, DateTime.Now.AddYears(-person.Age).Year }; // 익명 클래스 이용
            query02.ToList().ForEach((elem) => listBox1.Items.Add(string.Format(" {0} {1} ", elem.Name, elem.Year )));
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 한국에 사는 사람 출력
            var query = from person in people
                        where person.Address == "Korea"
                        select person;
            query.ToList().ForEach((elem) => listBox1.Items.Add(elem));
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 요소 이름순 출력
            var query = from person in people
                        orderby person.Name
                        select person;
            //query.ToList().ForEach((elem) => listBox1.Items.Add(elem));

            var query02 = people.OrderBy((elem) => elem.Name);
            query02.ToList().ForEach((elem) => listBox1.Items.Add(elem));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 요소 주소로 그룹핑해서 출력
            var query = from person in people
                        group person by person.Address;
            query.ToList().ForEach(
                (elem) => 
                {
                    listBox1.Items.Add(string.Format("[{0}]", elem.Key));
                    elem.ToList().ForEach((item) => listBox1.Items.Add(item));
                });

            listBox1.Items.Add(" ");
            // 언어 목록 그룹핑해서 출력
            var queryL = from lang in languages
                         group lang by lang.Name;
            queryL.ToList().ForEach(
                (elem)=> {
                    listBox1.Items.Add(string.Format("[{0}]", elem.Key));
                    elem.ToList().ForEach((item) => listBox1.Items.Add(item));
                });

            //var query02 = people.GroupBy((elem) => elem.Address);
            //query02.ToList().ForEach((elem) => listBox1.Items.Add(string.Format("{0}", elem.Key)));
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // 요소 주소로 그룹핑해서 출력
            var query02 = people.GroupBy((elem) => elem.Address);
            query02.ToList().ForEach((elem) => listBox1.Items.Add(string.Format("{0}", elem.Key)));
        }
        private void Button9_Click(object sender, EventArgs e)
        { //inner join
            listBox1.Items.Clear();
            // 정보와 사용언어 함께 출력
            var query = from person in people join lang in languages
                        on person.Name equals lang.Name
                        select new { person.Name, person.Age, person.Address, lang.Language };
            query.ToList().ForEach((elem) => listBox1.Items.Add(string.Format("{0} : {1}, {2} in {3} ", elem.Name, elem.Language, elem.Age, elem.Address)));
        }

        private void Button8_Click(object sender, EventArgs e)
        { //outer join
            listBox1.Items.Clear();
            // 정보와 사용언어 함께 출력 사용언어가 없는 정보도 출력
            var query = from person in people
                        join lang in languages on person.Name equals lang.Name into tempTable
                        from outertable in tempTable.DefaultIfEmpty(new MainLanguage())
                        select new { person.Name, person.Age, person.Address, outertable.Language };
            query.ToList().ForEach((elem) => listBox1.Items.Add(string.Format("{0} : {1,5}, {2} in {3} ", elem.Name, elem.Language, elem.Age, elem.Address)));

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
        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Language);
        }
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

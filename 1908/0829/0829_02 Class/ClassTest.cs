using MyNamespace.MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyNamespace.MyProduct
{
    class ClassTest
    {
        static void Main(string[] args)
        {
            Book alice = new Book("Alice");
            alice.pageCount = 3;
            Console.WriteLine(alice.printTitle("hello")); // 1=> / <=4
        }
    }
}
namespace MyNamespace.MyLibrary
{
    class Book // class 는 object를 상속한다. / default 접근제한자 : internal
    {
        string title;
        public int pageCount;
        public Book() { }
        public Book(string title)
        {
            this.title = title;
        }
        public string printTitle(string hello) // <=2
        {
            return title+hello;
        } //=>3
        public string printTitle(string hello, int a) // <=2
        {
            return a + hello;
        } //=>3

    }
}

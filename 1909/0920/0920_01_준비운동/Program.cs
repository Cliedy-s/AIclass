using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0920_01_준비운동
{
    [Serializable]
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0:5} {1:5} {2:5}", this.Name, this.Phone, this.Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<NameCard> ncls = new List<NameCard>();
            ncls.Add(new NameCard { Name = "김빠빠", Phone = "111", Age = 13 });
            ncls.Add(new NameCard { Name = "박빠빠", Phone = "222", Age = 65 });
            ncls.Add(new NameCard { Name = "창빠빠", Phone = "333", Age = 19 });

            string filePath = Environment.CurrentDirectory + @"\NameCardList.dat";

            //using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    BinaryFormatter bf = new BinaryFormatter(); // .net용

            //    bf.Serialize(fs, ncls);
            //}

            //ncls.Clear();

            //using (FileStream fs = new FileStream(filePath, FileMode.Open))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    ncls = bf.Deserialize(fs) as List<NameCard>;
            //}

            //foreach (var item in ncls)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                BinaryFormatter bf = new BinaryFormatter(); // .net용

                bf.Serialize(fs, ncls);
                ncls.Clear();
                ncls = bf.Deserialize(fs) as List<NameCard>;
                
            }

            foreach (var item in ncls)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}

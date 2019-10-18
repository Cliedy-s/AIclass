using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class PhoneInfo
    {
        string name;
        string phoneNumber;
        string birth;
                
        public PhoneInfo(string name, string num)
        {
            this.name = name;
            phoneNumber = num;
            this.birth = null;
        }
        public PhoneInfo(string name, string num, string birth)
        {
            this.name = name;
            phoneNumber = num;
            this.birth = birth;
        }

        public string Name { get => name; set => name = value; }

        public void showPhoneInfo()
        {
            Console.Write("name: " + this.name);
            Console.Write("\t phone: " + this.phoneNumber);
            if (birth != null)
                Console.Write("\t birth: " + this.birth);
            Console.WriteLine();
        }
    }
}

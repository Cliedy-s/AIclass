using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook1
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

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public void showPhoneInfo()
        {
            Console.Write("name: " + name);
            Console.Write("\t phone: " + phoneNumber);
            if (birth != null)
                Console.Write("\t birth: " + birth);
            Console.WriteLine();
        }
    }
}

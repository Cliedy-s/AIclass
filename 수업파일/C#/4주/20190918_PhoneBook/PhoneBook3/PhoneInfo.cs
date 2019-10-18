using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook3
{
    class PhoneInfo
    {
        string name;
        string phoneNumber;

        public PhoneInfo(string name, string num)
        {
            this.name = name;
            phoneNumber = num;
        }

        public string Name { get => name; set => name = value; }

        public void showPhoneInfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("phone: " + phoneNumber);
        }
    }

    class PhoneUnivInfo : PhoneInfo
    {
        string major;
	    int year;

        public PhoneUnivInfo(string name, string num, string major, int year) : base(name, num)
        {        
            this.major = major;
            this.year = year;
        }

        public override void showPhoneInfo()
        {
            base.showPhoneInfo();
            Console.WriteLine("major: " + major);
            Console.WriteLine("year: " + year);
        }
    }

    class PhoneCompanyInfo : PhoneInfo
    {
        string company;

        public PhoneCompanyInfo(string name, string num, string company) : base(name, num)
        {
   
            this.company = company;
        }

        public override void showPhoneInfo()
        {
            base.showPhoneInfo();
            Console.WriteLine("company: " + company);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02_Teacher
{
    public class PhoneInfo
    {
        string name;
        string phoneNumber;

        public PhoneInfo(string name, string num)
        {
            this.name = name;
            phoneNumber = num;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public virtual void ShowPhoneInfo()
        {
            Console.Write("name: " + name);
            Console.Write("\t phone: " + phoneNumber);
            Console.WriteLine();
        }
    }
    class PhoneUnivInfo : PhoneInfo {
        string major;
        int year;

        public PhoneUnivInfo(string name, string phoneNumber, string major, int year) : base(name, phoneNumber)
        {
            this.major = major;
            this.year = year;
        }
        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write("\tmajor: " + major);
            Console.Write("\t year: " + year);
            Console.WriteLine();
        }
    }
    class PhoneCompanyInfo : PhoneInfo
    {
        string company;

        public PhoneCompanyInfo(string name, string phoneNumber, string company) : base(name, phoneNumber)
        {
            this.company = company;
        }
        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write("\tcompany: " + company);
            Console.WriteLine();

        }
    }
}

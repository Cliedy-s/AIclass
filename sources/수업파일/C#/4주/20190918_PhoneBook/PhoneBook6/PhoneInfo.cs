using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook6
{
    class PhoneInfo : IComparable
    {
        string name;
        string phoneNumber;

        public PhoneInfo(string name, string num)
        {
            this.name = name;
            phoneNumber = num;
        }

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public virtual void showPhoneInfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("phone: " + phoneNumber);
        }

        public int CompareTo(object obj)
        {
            PhoneInfo o = (PhoneInfo)obj;
            return name.CompareTo(o.name);
        }

        public override string ToString()
        {
            return "name: " + name + "\t phone: " + phoneNumber;
        }
        
        public override bool Equals(object obj)
        {
            PhoneInfo info = (PhoneInfo)obj;

            return this.name.Equals(info.name) && this.phoneNumber.Equals(info.phoneNumber);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(name)
                    + EqualityComparer<string>.Default.GetHashCode(phoneNumber);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook04
{
    public class PhoneInfo : IComparable
    {
        string name;
        string phoneNumber;

        public override string ToString()
        {
            return string.Format("name : {0} \t phone : {1}", name, phoneNumber);
        }

        public PhoneInfo(string name, string num)
        {
            this.name = name;
            PhoneNumber = num;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public int CompareTo(object obj)
        {
            PhoneInfo info = (PhoneInfo)obj;
            return this.Name.CompareTo(info.Name);
        }

        public virtual void ShowPhoneInfo()
        {
            Console.Write("name: " + name);
            Console.Write("\t phone: " + PhoneNumber);
            Console.WriteLine();
        }
    }
    class PhoneUnivInfo : PhoneInfo
    {
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

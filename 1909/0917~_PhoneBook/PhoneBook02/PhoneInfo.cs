using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook02
{
    class PhoneInfo
    {
        string name;
        string phoneNumber;
        string birth;

        public string Name { get => name; set => name = value; }

        public PhoneInfo(string name, string phoneNumber) // console.ReadLine => "" => this(,,) , 생성자2를 탈 일은 없음
        {
            this.Name = name;
            this.phoneNumber = phoneNumber;
            this.birth = null;
        }

        public PhoneInfo(string name, string phoneNumber, string birth) : this(name, phoneNumber)
        {
            this.birth = birth;
        }

        public void ShowPhoneInfo()
        {
            // 2. 목록 출력
            Console.WriteLine("이름 : {0} 번호 : {1} 생일 : {2}", this.name, this.phoneNumber, this.birth);
        }
    }
}

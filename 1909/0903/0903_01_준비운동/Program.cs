using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903_01_준비운동
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount.ChangeInterestRate(1.3f);

            BankAccount soyeon = new BankAccount("356-1066-5326-13", "신소연");
            soyeon.Deposit(3000);
            Console.WriteLine(soyeon.LeftMoney());
            soyeon.Withdraw(2000);
            Console.WriteLine(soyeon.LeftMoney());
            soyeon.Prints();

        }
    }
    public class BankAccount
    {
        // static
        static float interestRate=0;
        public static void ChangeInterestRate(float interestRate)
        {
            BankAccount.interestRate = interestRate;
        }
        //

        // 인스턴스
        string name=string.Empty;
        decimal money = 0;

        // 리팩토링 : 필드 캡슐화 ( 필드 사용 ) 
        string accountNumber = string.Empty;
        public string AccountNumber { // 쓰기전용 : get(x), 읽기전용 : set(x)
            get => accountNumber;
            set => accountNumber = value;
        }

        // 스니핏 propfull : 변수까지 만들 때
        private string accNumber;
        public string AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }

        public BankAccount()
        {
            Console.WriteLine("Hello");
        }

        public BankAccount(string accountNumber, string name) : this() // : this() => 생성자를 상속받는다
        {
            this.AccountNumber = accountNumber;
            this.name = name;
        }

        public void Deposit (decimal depositMoney)
        {
            money += depositMoney + depositMoney*(decimal)interestRate;
        }

        public void Withdraw (decimal withdrawMoney)
        {   
            //
            if(money - withdrawMoney < 0)
            {
                Console.WriteLine("잔액이 부족합니다.");
                return ;
            }
            money -= withdrawMoney;
        }

        public decimal LeftMoney()
        {
            return money;
        }

        public void Prints()
        {
            Console.WriteLine("계좌번호 : {0}", AccountNumber);
            Console.WriteLine("예금주명 : {0}", name);
            Console.WriteLine("잔액 : {0}", money);
        }
    }
}

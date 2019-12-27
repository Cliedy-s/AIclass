using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0903
{
    class AccountManager
    {
        BankAccount account;

        //계좌관리프로그램메뉴
        public void PrintMenu()
        {
            Console.WriteLine("\n---Menu--------");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }

        //계좌개설
        public void MakeAccount()
        {
            //계좌번호, 이름을 입력받아서 계좌를 생성
            //개설된 계좌번호들을 저장할 데이터구조가 필요함
            Console.Write("계좌번호: ");
            string accNum = Console.ReadLine();
            Console.Write("예금주명: ");
            string name = Console.ReadLine();

            account = new BankAccount(accNum, name);
        }

        //입금
        public void Deposit()
        {
            //계좌번호, 입금액을 입력받아서 입금처리
            //계좌번호와 입금액 유효성 검사 필요

            if (account != null)
            {
                Console.Write("입금하실 금액은? : ");
                int money = int.Parse(Console.ReadLine());

                account.InputMoney(money);
            }
            else
            {
                Console.WriteLine("계좌개설부터 하십시오.");
            }
        }

        //출금
        public void WithDraw()
        {
            //계좌번호, 출금액을 입력받아서 입금처리
            //계좌번호와 출금액 유효성 검사 및 잔액 부족 여부 체크 필요

            if (account != null)
            {
                Console.Write("출금하실 금액은? : ");
                int money = int.Parse(Console.ReadLine());

                account.OutputMoney(money);
            }
            else
            {
                Console.WriteLine("계좌개설부터 하십시오.");
            }
        }

        //조회
        public void Inquire()
        {
            //등록된 계좌정보를 조회
            if (account != null)
            {
                account.PrintAccountInfo();
            }
            else
            {
                Console.WriteLine("계좌개설부터 하십시오.");
            }
        }
    }

    class AccountManagerProgram
    {
        static void Main(string[] args)
        {
            int choice;
            AccountManager manager = new AccountManager();

            while (true)
            {
                manager.PrintMenu();
                Console.Write("선택: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.MakeAccount();
                        break;
                    case 2:
                        manager.Deposit();
                        break;
                    case 3:
                        manager.WithDraw();
                        break;
                    case 4:
                        manager.Inquire();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("다시 선택하세요");
                        break;
                }
            }
        }
    }
}

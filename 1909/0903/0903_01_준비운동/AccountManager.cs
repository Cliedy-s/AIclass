using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903_01_준비운동
{
    enum ManagerMenu
    {
        OpenAccount=1, Deposit, Withdraw, PrintAccount, ProgramExit 
    }
    class AccountManager
    {
        BankAccount acc;

        public void PrintMenu()
        {
            Console.WriteLine("---Menu-------");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }
        public void OpenAccount()
        {
            if (acc == null)
            {
                Console.Write("계좌번호 : ");
                string accountNumber = Console.ReadLine();
                Console.Write("예금주명 : ");
                string name = Console.ReadLine();

                acc = new BankAccount(accountNumber, name);
                BankAccount.ChangeInterestRate(0.2f);
            }
            else
                Console.WriteLine(" :: 이미 계좌를 개설하셨습니다.");
        }
        public void Deposit(decimal depositMoney)
        {
            acc.Deposit(depositMoney);
        }
        public void Withdraw(decimal withdrawMoney)
        {
            acc.Withdraw(withdrawMoney);
        }

        public void Prints()
        {
            acc.Prints();
        }

        public bool isNullCheck()
        {

            if (acc == null)
            {
                Console.WriteLine("계좌를 개설해주세요");
                return true;
            }
            else
                return false;
        }

        public decimal ReturnDecimalMoney()
        {
            try
            {
                return decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} 다시 입력해주세요", e.Message);
                return 0;
            }
        }
    }
    class AccountManagerProgram
    {
        static void Main(string[] args)
        {
            AccountManager am = new AccountManager();
            decimal money = 0;
            while (true)
            {
                money = 0;

                am.PrintMenu();
                Console.Write("선택 : ");

                ManagerMenu mu;
                try { 
                mu = (ManagerMenu)int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + "다시 입력해주세요");
                    continue;
                }
                #region 스위치문

                switch (mu)
                {
                    case ManagerMenu.OpenAccount: // 1. 계좌개설
                        am.OpenAccount();
                        break;
                    case ManagerMenu.Deposit: // 2. 입금
                        if (am.isNullCheck())
                            break;
                        money = am.ReturnDecimalMoney();
                        if (money!=0)
                            am.Deposit(money);
                        break;
                    case ManagerMenu.Withdraw: // 3. 출금
                        if (am.isNullCheck())
                            break;
                        money = am.ReturnDecimalMoney();
                        if (money != 0)
                            am.Withdraw(money);
                        break;
                    case ManagerMenu.PrintAccount: // 4. 잔액조회
                        if (am.isNullCheck())
                            break;
                        am.Prints();
                        break;
                    case ManagerMenu.ProgramExit: // 5. 프로그램 종료
                        goto OUT_PROGRAM;
                    default:
                        Console.WriteLine("1~5 사이의 숫자를 입력해주세요");
                        break;
                }

                #endregion
            }
        OUT_PROGRAM:;
        }
    }

}

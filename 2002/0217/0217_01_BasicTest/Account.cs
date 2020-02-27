using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0217_01_BasicTest
{
    public class Account
    {

        double m_balance;

        public Account()
        {
            Balance = 0.0;
        }
        public Account(double balance)
        {
            Balance = balance;
        }

        public double Balance { get { return m_balance; } set { m_balance = value; } }
        public void Withdraw(double amount)
        {
            if(m_balance < amount)
                throw new ArgumentException("잔액이 부족합니다.", nameof(amount));
            m_balance -= amount;
        }
    }
}

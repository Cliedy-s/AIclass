using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0217_01_BasicTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0217_01_BasicTest.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            _0217_01_BasicTest.Account account = new Account(3000);
            account.Withdraw(3000);
            Assert.AreEqual(0, account.Balance);
        }
        [TestMethod()]
        public void WithdrawTest1()
        {
            _0217_01_BasicTest.Account account = new Account(3000);
            Assert.ThrowsException<ArgumentException>(()=> account.Withdraw(5000));
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "유효범위 초과")]
        public void WithdrawTest2()
        {
            _0217_01_BasicTest.Account account = new Account(3000);
            account.Withdraw(4000);
        }
    }
}
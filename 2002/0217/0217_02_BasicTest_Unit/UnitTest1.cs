using _0217_01_BasicTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0217_01_BasicTest.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void AddTest()
        {
            _0217_01_BasicTest.Program program = new Program();
            double returnresult = program.Add(10, 10);
            Assert.AreEqual(returnresult, 20);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            _0217_01_BasicTest.Program program = new Program();
            double returnresult = program.Substract(10, 10);
            Assert.AreEqual(returnresult, 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            _0217_01_BasicTest.Program program = new Program();
            double returnresult = program.Multiply(10, 10);
            Assert.AreEqual(returnresult, 100);
        }

        [TestMethod()]
        public void DiviedTest()
        {

            _0217_01_BasicTest.Program program = new Program();
            double returnresult = program.Divied(10, 10);
            Assert.AreEqual(returnresult, 1);
        }
    }
}

namespace _0217_02_BasicTest_Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CITraining.MSTest
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void TestAddMethod()
        {
            Assert.IsTrue(1 + 1 == 2);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            Assert.IsTrue(1 - 1 == 0);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            Assert.IsTrue(1 * 1 == 1);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(65, GetResult("+ 7 58"));
        }

        public string[] GetResult(string calculation)
        {
            string[] calculationString = calculation.Split(' ');

            return calculationString;
        }
    }
}

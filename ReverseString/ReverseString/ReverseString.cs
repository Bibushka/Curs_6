using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseString
{
    [TestClass]
    public class ReverseString
    {
        [TestMethod]
        public void TestStringReversal()
        {
            Assert.AreEqual("yppah", Reverse("happy",""));
        }

        public string Reverse(string initialString, string newString)
        {
            return "";
        }
    }
}

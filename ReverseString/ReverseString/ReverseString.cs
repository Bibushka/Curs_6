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
            Assert.AreEqual("pots", Reverse("stop",""));
        }

        public string Reverse(string initialString, string newString)
        {
            if (initialString.Length == 0)
                return newString;
            newString = newString + initialString[initialString.Length-1];
            initialString = initialString.Remove(initialString.Length - 1);
            return Reverse(initialString, newString);
        }
    }
}

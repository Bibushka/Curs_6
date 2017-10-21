using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInString
{
    [TestClass]
    public class StringInString
    {
        [TestMethod]
        public void IsStringCorrectlyComposed()
        {
            Assert.AreEqual("wordinword", InsertString("wordsword", "in", 4));
        }

        public string InsertString(string initialString, string stringToBeInserted, int position)
        {
            return "";
        }
    }
}

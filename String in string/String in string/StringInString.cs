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
            Assert.AreEqual("dosomestuff", PrepareForInsertion("doestuff", "some", 2));
        }

        public string PrepareForInsertion(string initialString, string 
            stringToBeInserted, int position)
        {
            return InsertString(initialString.Substring(0, position),
                stringToBeInserted + initialString.Substring(position + 1));
        }

        public string InsertString(string initialString, string stringToBeInserted)
        {
            if (stringToBeInserted.Length == 0)
                return initialString;
            initialString = initialString + stringToBeInserted[0];
            stringToBeInserted = stringToBeInserted.Substring(1);
            return InsertString(initialString, stringToBeInserted);
        }
    }
}

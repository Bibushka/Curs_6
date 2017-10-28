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
            Assert.AreEqual("rdadapsda", PrepareForInsertion("raapsa", "da", 'a'));
        }

        public string PrepareForInsertion(string initialString, string 
            stringToBeInserted, char charToChange)
        {
            string newString = string.Empty;
            return ChangeChar(initialString, stringToBeInserted, charToChange, newString);
        }

        public string ChangeChar(string initialString, string stringToBeInserted, 
            char CharToChange, string newString)
        {
            if (initialString.Length == 0)
                return newString;
            var toAdd = initialString[0] == CharToChange ? stringToBeInserted : initialString[0].ToString();
            return ChangeChar(initialString.Substring(1), stringToBeInserted, 
                CharToChange, newString + toAdd);
        }
    }
}

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
            if (initialString[0] == CharToChange)
                return ChangeChar(initialString.Substring(1), stringToBeInserted, 
                    CharToChange, newString + stringToBeInserted);
            return ChangeChar(initialString.Substring(1), stringToBeInserted, 
                CharToChange, newString + initialString[0]);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(58.7, GetResult("58.7"));
        }

        public float GetResult(string calculatorScreen)
        {
            string[] calculationString = calculatorScreen.Split(' ');
            float result = 0;
            return Split(calculationString, result);
        }

        public float Split(string[] calculationString, float result)
        {
            if (calculationString.Length == 0)
                return result;
            return Split(ResizeString(calculationString, calculationString.Length-1), 
                result + float.Parse(calculationString[calculationString.Length - 1], System.Globalization.CultureInfo.InvariantCulture));
        }

        public string[] ResizeString(string[] yourString, int lenght)
        {
            Array.Reverse(yourString);
            Array.Resize(ref yourString, lenght);
            Array.Reverse(yourString);
            return yourString;
        }
    }
}

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
        public void SingleIntTest()
        {
            Assert.AreEqual(58, GetResult("58"));
        }

        [TestMethod]
        public void SingleDoubleTest()
        {
            Assert.AreEqual(58.7, GetResult("58.7"));
        }

        [TestMethod]
        public void SingleDoublePlusTest()
        {
            Assert.AreEqual(58.7, GetResult("+ 58.7"));
        }


        [TestMethod]
        public void FullTest()
        {
            Assert.AreEqual(8, GetResult("* + 1 1 + 2 2"));
        }

        public double GetResult(string calculatorScreen)
        {
            string[] calculationString = calculatorScreen.Split(' ');
            if (calculationString.Length <= 2)
                return double.Parse(calculationString[calculationString.Length-1]);
            int index = 0;
            return Split(calculationString, ref index);
        }

        public double Split(string[] calculationString, ref int index)
        {
            double result;
            index++;
            if (double.TryParse(calculationString[index-1], out result))
                return result;
            switch (calculationString[index-1])
            {
                case "+":
                    return Split(calculationString, ref index) + Split(calculationString, ref index);
                case "-":
                    return Split(calculationString, ref index) - Split(calculationString, ref index);
                case "/":
                    return Split(calculationString, ref index) / Split(calculationString, ref index);
                default:
                    return Split(calculationString, ref index) * Split(calculationString, ref index);
            }
        }
    }
}

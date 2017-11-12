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
            Assert.AreEqual(32.4, GetResult("/ + 6 58.8 2"));
        }

        public double GetResult(string calculatorScreen)
        {
            string[] calculationString = calculatorScreen.Split(' ');
            if (calculationString.Length <= 2)
                return double.Parse(calculationString[calculationString.Length-1]);
            return Split(calculationString, calculationString.Length/2-1 , calculationString.Length/2);
        }

        public double Split(string[] calculationString, int frontIndex, int backIndex)
        {
            if (frontIndex == -1)
                return double.Parse(calculationString[backIndex]);
            switch (calculationString[frontIndex])
            {
                case "+":
                    calculationString[backIndex + 1] = 
                        (double.Parse(calculationString[backIndex]) + 
                        double.Parse(calculationString[backIndex+1])).ToString();
                    break;
                case "-":
                    calculationString[backIndex + 1] =
                        (double.Parse(calculationString[backIndex]) +
                        double.Parse(calculationString[backIndex - 1])).ToString();
                    break;
                case "/":
                    calculationString[backIndex + 1] =
                        (double.Parse(calculationString[backIndex]) /
                        double.Parse(calculationString[backIndex + 1])).ToString();
                    break;
                case "*":
                    calculationString[backIndex + 1] =
                        (double.Parse(calculationString[backIndex]) *
                        double.Parse(calculationString[backIndex + 1])).ToString();
                    break;
            }
            return Split(calculationString, frontIndex - 1, backIndex + 1);
        }
    }
}

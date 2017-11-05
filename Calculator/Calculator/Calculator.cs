using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(65, GetResult("+ 7 58"));
        }

        public int[] GetResult(string calculatorScreen)
        {
            string[] calculationString = calculatorScreen.Split(' ');
            string[][] splitString = new string[2][];
            splitString[0] = new string[calculationString.Length/2];
            splitString[1] = new string[calculationString.Length / 2 + 1];
            splitString = Split(calculationString, splitString, 0, 0);
            string[] simbols = splitString[0];
            int[] numbers = Array.ConvertAll(splitString[1], int.Parse);
            return numbers;
        }

        public string[][] Split(string[] calculationString, string[][] splitString, int i, int j)
        {
            string[] newString = new string[calculationString.Length-1];
            if (calculationString.Length == 0)
                return splitString;
            if ("+-/*".Contains(calculationString[calculationString.Length - 1]))
            {
                splitString[0][i] = calculationString[calculationString.Length - 1];
                Array.Copy(calculationString, newString, newString.Length);
                return Split(newString, splitString, i + 1, j);
            }
            splitString[0][j] = calculationString[calculationString.Length - 1];
            Array.Copy(calculationString, newString, newString.Length);
            return Split(newString, splitString, i, j + 1);
        }
    }
}

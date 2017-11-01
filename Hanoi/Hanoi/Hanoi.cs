using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hanoi
{
    [TestClass]
    public class Hanoi
    {
        [TestMethod]
        public void GetHanoiResult()
        {
            Assert.AreEqual("AC AB CB AC BA BC AC", GetHanoiString(3));
        }

        public string GetHanoiString(int n)
        {
            string moves = string.Empty;
            string a = "A";
            string b = "B";
            string c = "C";
            return GetMoves(n, moves, a, c, b);
        }

        public string GetMoves(int n, string moves, string a, string b, string c)
        {
            return "";
        }
    }
}

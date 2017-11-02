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
            Assert.AreEqual("AC AB CB AC BA BC AC ", GetHanoiString(3));
        }

        public string GetHanoiString(int n)
        {
            string a = "A";
            string b = "B";
            string c = "C";
            return GetMoves(n, a, c, b);
        }

        public string GetMoves(int n, string a, string b, string c)
        {
            string moves = string.Empty;
            if (n == 1)
                return a + b + " ";
            moves = moves + GetMoves(n - 1, a, c, b);
            moves = moves + a + b + " ";
            moves = moves + GetMoves(n - 1, c, b, a);
            return moves;
        }
    }
}

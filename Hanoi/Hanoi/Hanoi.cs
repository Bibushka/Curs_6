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
            return GetMoves(n, moves, a, b, c);
        }

        public string GetMoves(int n, string moves, string a, string b, string c)
        {
            if (n == 1)
                return GetMoves(n, moves + a + b + " ", a, b, c);
            GetMoves(n - 1, moves + a + b + " ", a, c, b);
            GetMoves(n - 1, moves + a + b + " ", c, b, a);
            GetMoves(n - 1, moves + a + b + " ", b, c, a);
            return moves;
        }
    }
}

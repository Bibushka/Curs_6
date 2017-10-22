using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle
{
    [TestClass]
    public class Triangle
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, GenerateTriangle(5));
        }

        public Array GenerateTriangle(int n)
        {
            return GetTriangleLine(n, 2, new int[] { 1, 1});
        }

        public Array GetTriangleLine(int n, int i, int[] line)
        {
            return new int[] { 0 };
        }
    }
}

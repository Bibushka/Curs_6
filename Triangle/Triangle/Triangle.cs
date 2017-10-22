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

        public int[] GenerateTriangle(int n)
        {
            return GetTriangleLine(n, 2, new int[] { 1, 1});
        }

        public int[] GetTriangleLine(int n, int i, int[] line)
        {
            if (i == n)
                return line;
            return GetTriangleLine(n, i + 1, CreateLine(i, line));
        }

        public int[] CreateLine(int i, int[] line)
        {
            int[] newLine = new int[line.Length + 1];
            newLine[0] = 1;
            newLine[newLine.Length - 1] = 1;
            for (int a = 1; a < line.Length; a++)
                newLine[a] = line[a - 1] + line[a];
            return newLine;
        }
    }
}

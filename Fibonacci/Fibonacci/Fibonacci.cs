﻿using System;
using Xunit;

namespace Fibonacci
{
    public class Fibonacci
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(6,8)]
        public void TestFibonacciRunning(int n, int result)
        {
            Assert.Equal(result, CalculateFibonacci(n, n, 0, 1));
        }

        public int CalculateFibonacci(int n, int i, int previous, int current)
        {
            if (n < 2)
                return n;
            if(i!=0)
                CalculateFibonacci(n, i--, current, previous + current);
            return current;
        }
    }
}

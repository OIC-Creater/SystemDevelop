using NUnit.Framework;
using System;


namespace SystemDevelop.Model.Tests
{
    [TestFixture]
    public class RsakeyTests
    {
        public void RsaTests(int expectedA, int expectedB, int a, int b)
        {
             RsakeyTests rsa = new RsakeyTests();

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }
        public void BetweenTest(bool expected, int lower, int current, int higher, bool inclusive = true)
        {
            bool result = MyCompare.Between(lower, current, higher, inclusive);
            Assert.AreEqual(expected, result);
        }

    }
}
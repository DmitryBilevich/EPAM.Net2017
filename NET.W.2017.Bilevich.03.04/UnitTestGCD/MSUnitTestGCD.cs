using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2017.Bilevich._03._04;

namespace MSUnitTestGCD
{
    [TestClass]
    public class GreatestCommonDivisorTest
    {

        [TestMethod]
        public void GetGCDTest()
        {
            GreatestCommonDivisor gcd = new GreatestCommonDivisor();
            int result = gcd.GetGCDbyEvclideAl(15, 0);
            Assert.AreEqual(result, 15);
            result = gcd.GetGCDbyEvclideAl(15, -5);
            Assert.AreEqual(result, 5);

            result = gcd.GetGCDSteinAl(15, 0);
            Assert.AreEqual(result, 15);
            result = gcd.GetGCDSteinAl(15, -5);
            Assert.AreEqual(result, 5);
        }
    }
}

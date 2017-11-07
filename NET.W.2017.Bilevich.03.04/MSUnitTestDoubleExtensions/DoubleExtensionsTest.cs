using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleExtensions;

namespace MSUnitTestDoubleExtensions
{
    [TestClass]
    public class DoubleExtensionsTest
    {

        [TestMethod]
        public void TestMethod1()
        {

            //    [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
            //[TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
            //[TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
            //[TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
            //[TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
            //[TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
            //[TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
            //[TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
            //[TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
            //ниже исправила опечатки
            //   [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
            //  [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
            string result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(-255.255);
            Assert.AreEqual(result, "1100000001101111111010000010100011110101110000101000111101011100");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(255.255);
            Assert.AreEqual(result, "0100000001101111111010000010100011110101110000101000111101011100");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(4294967295.0);
            Assert.AreEqual(result, "0100000111101111111111111111111111111111111000000000000000000000");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.MinValue);
            Assert.AreEqual(result, "1111111111101111111111111111111111111111111111111111111111111111");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.MaxValue);
            Assert.AreEqual(result, "0111111111101111111111111111111111111111111111111111111111111111");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.Epsilon);
            Assert.AreEqual(result, "0000000000000000000000000000000000000000000000000000000000000001");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.NaN);
            Assert.AreEqual(result, "1111111111111000000000000000000000000000000000000000000000000000");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.NegativeInfinity);
            Assert.AreEqual(result, "1111111111110000000000000000000000000000000000000000000000000000");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(double.PositiveInfinity);
            Assert.AreEqual(result, "0111111111110000000000000000000000000000000000000000000000000000");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(-0.0);
            Assert.AreEqual(result, "1000000000000000000000000000000000000000000000000000000000000000");

            result = DoubleExtensions.DoubleExtensions.DoubleToIEEE754(0.0);
            Assert.AreEqual(result, "0000000000000000000000000000000000000000000000000000000000000000");
        }
    }
}

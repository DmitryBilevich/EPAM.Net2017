using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNextBiggerNumber;

namespace MSUnitTestFindNextBiggerNumber
{
    [TestClass]
    public class FindNextBiggerNumberTest
    {        
            //[TestCase(12, ExpectedResult = 21)]
            //[TestCase(513, ExpectedResult = 531)]
            //[TestCase(2017, ExpectedResult = 2071)]
            //[TestCase(414, ExpectedResult = 441)]
            //[TestCase(144, ExpectedResult = 414)]
            //[TestCase(1234321, ExpectedResult = 1241233)]
            //[TestCase(1234126, ExpectedResult = 1234162)]
            //[TestCase(3456432, ExpectedResult = 3462345)]
            //[TestCase(10, ExpectedResult = -1)]
            //[TestCase(20, ExpectedResult = -1)]
            
        [TestMethod()]
        public void FindNextBiggerNumberTes()
        {
            Task2 item = new Task2();
            long number = 12;
            long expectedResult = 21;
            long result = item.FindNextBiggerNumber(number);
            
            Assert.AreEqual(expectedResult, result);
            
            number = 513;
            expectedResult = 531;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 2017;
            expectedResult = 2071;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 414;
            expectedResult = 441;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 1234321;
            expectedResult = 1241233;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 1234126;
            expectedResult = 1234162;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 3456432;
            expectedResult = 3462345;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 144;
            expectedResult = 414;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 10;
            expectedResult = -1;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

            number = 20;
            expectedResult = -1;
            result = item.FindNextBiggerNumber(number);
            Assert.AreEqual(expectedResult, result);

        }
    }
}

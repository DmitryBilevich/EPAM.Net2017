using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDigit;
using System.Collections.Generic;

namespace MSUnitTestFilterDigist
{
    [TestClass]
    public class FilterDigistTest
    {
        [TestMethod]
        public void FilterDigistTestOne()
        {
            Task4 item = new Task4();
            List<int> numbers = new List<int>() {14, 51, 72, 4, 88, 11, 41, 7, 1482};
            List<int> expectedResult = new List<int>() {14, 4, 41, 1482 };
            int numberByCompare = 4;
            List<int> result = item.FilterDigit(numbers, numberByCompare);
            expectedResult.Any(element => expectedResult.Contains(element));
        }
    }
}

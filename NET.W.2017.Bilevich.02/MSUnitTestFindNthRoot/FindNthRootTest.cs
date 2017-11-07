using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNthRoot;

namespace MSUnitTestFindNthRoot
{
    [TestClass]
    public class FindNthRootTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            

            double result = Task5.FindNthRoot(1, 5, 0.0001);
            double expResult = 1;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(8, 3, 0.0001);
            expResult = 2;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(0.001, 3, 0.0001);
            expResult = 0.1;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(0.04100625, 4, 0.0001);
            expResult = 0.45;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(0.0279936, 7, 0.0001);
            expResult = 0.6;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(0.0081, 4, 0.1);
            expResult = 0.3;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(-0.008, 3, 0.1);
            expResult = -0.2;
            Assert.AreEqual(expResult, result);

            result = Task5.FindNthRoot(0.004241979, 9, 0.00000001);
            expResult = 0.545;
            Assert.AreEqual(expResult, result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using InsertNumber;

namespace MSUnitTestInsertNumber
{
    [TestClass]
    public class InsertNumberTest
    {
        private int ConvertBitArrayToNumber(int[] array)
        {
            var bitArray = new BitArray(32);
            for (int i = 0; i < 32; i++)
            {
                bitArray[i] = array[i] == 1;
            }

            array = new int[1];
            bitArray.CopyTo(array, 0);

            return array[0];
        }

        [TestMethod]
        public void InsertNunTest()
        {
            Task1 item = new Task1();
            var result = item.InsertNun(15, 15, 0, 0);
            int number = ConvertBitArrayToNumber(result);
            Assert.AreEqual(number, 15);

            result = item.InsertNun(8, 15, 0, 0);
            number = ConvertBitArrayToNumber(result);
            Assert.AreEqual(number, 9);

            result = item.InsertNun(8, 15, 3, 8);
            number = ConvertBitArrayToNumber(result);
            Assert.AreEqual(number, 120);
        }
    }
}

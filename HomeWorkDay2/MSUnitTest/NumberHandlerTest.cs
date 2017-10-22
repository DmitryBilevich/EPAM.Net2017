using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using HomeWorkDay2;

namespace MSUnitTest
{
    [TestClass]
    public class NumberHandlerTest
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
            NumberHandler handler = new NumberHandler();
            var result = handler.InsertNun(15, 15, 0, 0);
            int number = ConvertBitArrayToNumber(result);
            Assert.AreEqual(number, 15);

            result= handler.InsertNun(8, 15, 0, 0);
            number = ConvertBitArrayToNumber(result);                    
            Assert.AreEqual(number, 9);

            result = handler.InsertNun(8, 15, 3, 8);
            number = ConvertBitArrayToNumber(result);
            Assert.AreEqual(number, 120);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay2
{
    public class NumberHandler
    {
        public int[] InsertNun(int numS, int numIn, int i, int j) {
            if (i>32|| j>32 || i>j)
            {
                throw new Exception("Invalid value of argument i or j"); 
            }
            BitArray bitArrNumSource = new BitArray(new int[] { numS });
            //int[] numberSource = bitArrNumSource.Cast<bool>().Select(bit => bit ? 1 : 0).ToArray();
            int[] numberSource = new int[32];
            for (var item = 0; item < bitArrNumSource.Length; item++)
            {
                numberSource[item] = (bitArrNumSource[item]) ? 1 : 0;
                Console.Write(numberSource[item]);
            }
            Console.WriteLine(" ");
            BitArray bitArrNumIn = new BitArray(new int[] { numIn });
            //int[] numberIn = bitArrNumIn.Cast<bool>().Select(bit => bit ? 1 : 0).ToArray();
            int[] numberIn= new int[32];
            for (var item = 0; item < bitArrNumIn.Length; item++)
            {
                numberIn[item] = (bitArrNumIn[item]) ? 1 : 0;
                Console.Write(numberIn[item]);
            }
            Console.WriteLine(" ");

            int[] numberResult = numberSource;

            int n = 0;
            for(var item=i; item<=j; item++)
            {                       
                    numberResult[item] = numberIn[n];
                n++;                
            }

            for (var item = 0; item < numberResult.Length; item++)
            {                
                Console.Write(numberResult[item]);
            }
            return numberResult;
        }
    }
}

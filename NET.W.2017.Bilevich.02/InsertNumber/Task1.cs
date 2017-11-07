using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    public class Task1
    {
        public int[] InsertNun(int numS, int numIn, int i, int j)
        {
            if (i > 32 || j > 32 || i > j)
            {
                throw new Exception("Invalid value of argument i or j");
            }
            BitArray bitArrNumSource = new BitArray(new int[] { numS });            
            int[] numberSource = new int[32];
            for (var item = 0; item < bitArrNumSource.Length; item++)
            {
                numberSource[item] = (bitArrNumSource[item]) ? 1 : 0;
                
            }
            
            BitArray bitArrNumIn = new BitArray(new int[] { numIn });
            int[] numberIn = new int[32];
            for (var item = 0; item < bitArrNumIn.Length; item++)
            {
                numberIn[item] = (bitArrNumIn[item]) ? 1 : 0;
                
            }
            

            int[] numberResult = numberSource;

            int n = 0;
            for (var item = i; item <= j; item++)
            {
                numberResult[item] = numberIn[n];
                n++;
            }

            
            return numberResult;
        }

        
    }
}

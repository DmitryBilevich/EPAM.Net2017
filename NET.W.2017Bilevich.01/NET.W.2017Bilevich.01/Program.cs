using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.W._2017Bilevich._01.Sort;

namespace NET.W._2017Bilevich._01
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = { 9, 1, 5, 12, 3, 7, 9, 18, 5, 91, 6, 4, 27 };
            SortArray.Quicksort (arrayOne);
            foreach (int item in arrayOne)
            {
                System.Console.Write(item + "  ");
            }
            Console.WriteLine();

            int[] arrayTwo = { 2, 7, 6, 4, 2, 6, 8, 79, 56, 23, 18, 30 };
            arrayTwo=SortArray.MergeSort(arrayTwo);
            foreach (int item in arrayTwo)
            {
                System.Console.Write(item  + "  ");
            }
        }
    }
}

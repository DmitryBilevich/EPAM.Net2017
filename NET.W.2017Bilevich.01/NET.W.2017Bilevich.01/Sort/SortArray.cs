using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2017Bilevich._01.Sort
{
   public class SortArray
    {
        public static void Quicksort(int[] arr)
        {
            if (arr.Length > 1) Quicksort(arr, 0, arr.Length - 1);
        }

        private static void Quicksort(int[] array, int first, int last)
        {
            int pivot = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < pivot && i <= last) ++i;

                while (array[j] > pivot && j >= first) --j;

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Quicksort(array, first, j);
            if (i < last) Quicksort(array, i, last);
        }

        

        public static int[] MergeSort(int[] buff)
        {            
            if (buff.Length > 1)
            {
                
                int[] left = new int[buff.Length / 2];                
                int[] right = new int[buff.Length - left.Length];
               
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = buff[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = buff[left.Length + i];
                }
                
                if (left.Length > 1)
                    left = MergeSort(left);
                if (right.Length > 1)
                    right = MergeSort(right);
                
                buff = MergeSort(left, right);
            }
              
            return buff;
        }

        private static int[] MergeSort(int[] left, int[] right)
        {
            
            int[] buff = new int[left.Length + right.Length];
            
            int i = 0;  
            int l = 0;  
            int r = 0;  
            for (; i < buff.Length; i++)
            {
                
                if (r >= right.Length)
                {
                    buff[i] = left[l];
                    l++;
                }
                
                else if (l < left.Length && left[l] < right[r])
                {
                    buff[i] = left[l];
                    l++;
                }
                
                else
                {
                    buff[i] = right[r];
                    r++;
                                        
                }
            }
            
            return buff;
        }
    }
}

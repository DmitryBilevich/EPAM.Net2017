using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FindNextBiggerNumber
{
    public class Task2
    {
        
            public long ExecutionTime { get; private set; }
            

            public Int64 FindNextBiggerNumber(long num)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (num<0)
            {
                throw new Exception("number less  or equal 0");
            }
            string number = num.ToString();
            int[] array = new int [number.Length];
            List<int> rigthArray=new List<int>();
            List<int> leftArray=new List<int>();
            Int64 result = -1;
            string resultNumber = "";
            int point;
            int indexPoint;
            int left, rigth=0;            

            for (var i=0; i<number.Length; i++)
            {
                array[i] = int.Parse(number[i].ToString());
            }

            for (var i=1; i<= array.Length-1; i++)
            {
                
                rigth = array[array.Length - i];
                left = array[array.Length - i-1];

                if (rigth>left)
                {
                    point = left;
                    indexPoint = array.Length - i - 1;                    
                    for(var j=0; j< array.Length; j++)
                    {
                        if (j <= indexPoint)
                            leftArray.Add(array[j]);
                        else
                            rigthArray.Add(array[j]);
                        
                    }

                    int interimNum = rigthArray.Where(x => x > point).Min();
                    rigthArray.Remove(interimNum);
                    
                    leftArray.Insert(leftArray.Count - 1, interimNum);                    
                    rigthArray.Sort();                    
                    leftArray.AddRange(rigthArray);

                    
                    foreach (var item in leftArray)
                    {
                        resultNumber += item;
                    }
                    stopWatch.Stop();
                    ExecutionTime = stopWatch.ElapsedTicks;
                    return result = Convert.ToInt64(resultNumber);
                }
                
            }
            stopWatch.Stop();
            ExecutionTime = stopWatch.ElapsedTicks;
            return result;
        }
    }
}

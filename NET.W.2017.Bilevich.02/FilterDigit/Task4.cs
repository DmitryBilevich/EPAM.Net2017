using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    public class Task4
    {
        public List<int> FilterDigit(List<int> numbers, int numberToCompare)
        {
            List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                List<int> digists = DivideNumberByDigists(item);
                foreach (var digist in digists)
                {
                    if (digist==numberToCompare)
                    {
                        result.Add(item);
                        break;
                    }
                }
            }

            return result;
        }

        private List<int> DivideNumberByDigists(int num)
        {
            List<int> result = new List<int>();
            string number = num.ToString();
            for (var i=0; i<number.Length; i++)
            {
                result.Add(int.Parse(number[i].ToString()));
            }
            return result;
        }
    }
}

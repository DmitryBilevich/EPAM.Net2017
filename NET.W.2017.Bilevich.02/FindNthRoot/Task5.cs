using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot
{
    public class Task5
    {
        public static double FindNthRoot(double a, double n, double eps)
        {
            var supposition = a / n;
            var result = (1 / n) * ((n - 1) * supposition + a / Math.Pow(supposition, (int)n - 1));

            while (Math.Abs(result - supposition) > eps)
            {
                supposition = result;
                result = (1 / n) * ((n - 1) * supposition + a / Math.Pow(supposition, (int)n - 1));
            }
            int accuracy = 0;
            while (eps != 1)
            {
                accuracy += 1;
                eps *= 10;
            }
            result = Math.Round(result, accuracy);
            return result;
        }
    }
}

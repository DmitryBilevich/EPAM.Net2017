using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleExtensions
{
    
        public static class DoubleExtensions
        {
            public static string DoubleToIEEE754(this double number)
            {
                if (number == 0)
                    return "0";

                string firstBit = number > 0 ? "0" : "1";
                number = number > 0 ? number : number * -1;
                IList<string> fractional = new List<string>();
                IList<string> integer = null;
                IList<string> expList = null;
                string integerStr = string.Empty;
                string fractionalStr = string.Empty;
                int exp;
                string expStr;

                long a = (long)Math.Truncate(number); // integer
                if (a < 0)
                    a = long.MaxValue;
                double b = number - a; //fractional

                 
                if (b > 0)
                {
                    for (var i = 0; i < 52; i++)
                    {
                        if (b == 0)
                        {
                            fractional.Add("0");
                            continue;
                        }
                        b = b * 2;
                        fractional.Add(Math.Truncate(b).ToString());
                        b = b - Math.Truncate(b);
                    }
                    fractionalStr = string.Join("", fractional);
                }
                else
                {
                    for (var i = 0; i < 52; i++)
                    {
                        fractional.Add("0");
                    }
                    fractionalStr = string.Join("", fractional);
                }

                
                if (a > 0)
                {
                    integer = new List<string>();
                    while (a != 0)
                    {
                        long d = a % 2;
                        integer.Add(d.ToString());
                        a = a / 2;
                    }
                    integerStr = string.Join("", integer.Reverse().Select(i => i.ToString())).Remove(0, 1);
                    exp = integer.Count() - 1 + 1023;
                }
                else
                {
                    fractionalStr = fractionalStr.Remove(0, 1);
                    exp = (fractional.Count() - 1) * -1 + 1023;
                }

                expList = new List<string>();
                while (exp != 0)
                {
                    int d = exp % 2;
                    expList.Add(d.ToString());
                    exp = exp / 2;
                }
                expStr = string.Join("", expList.Reverse().Select(i => i.ToString()));


                string result = String.Format("{0}{1}{2}{3}", firstBit, expStr, integerStr, fractionalStr).Substring(0, 64);

                return result;
            }
        }
    }

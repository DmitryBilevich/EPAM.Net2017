using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    
        public class GreatestCommonDivisor
        {
            public long ExecutionTime { get; private set; }
            public int GetGCDbyEvclideAl(params int[] num)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                int a = Math.Abs(num[0]);

                for (var i = 1; i < num.Length; i++)
                {
                    int b = Math.Abs(num[i]);
                    if (a != 0 || b != 0)
                    {
                        a = EvclideAlgorithm(a, b);
                    }
                    else if (a == 0)
                    {
                        a = b;
                        continue;
                    }
                    else if (b == 0)
                    {
                        continue;
                    }
                    stopWatch.Stop();
                    ExecutionTime = stopWatch.ElapsedTicks;

                }
                return a;
            }

            public int GetGCDSteinAl(params int[] num)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                int a = Math.Abs(num[0]);

                for (var i = 1; i < num.Length; i++)
                {
                    int b = Math.Abs(num[i]);
                    if (a != 0 || b != 0)
                    {
                        a = SteinAlgorithm(a, b);
                    }
                    else if (a == 0)
                    {
                        a = b;
                        continue;
                    }
                    else if (b == 0)
                    {
                        continue;
                    }
                    stopWatch.Stop();
                    ExecutionTime = stopWatch.ElapsedTicks;
                }
                return a;
            }

            private int EvclideAlgorithm(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;

            }

            private int SteinAlgorithm(int a, int b)
            {
                if (a == b)
                    return a;
                if (a == 0)
                    return b;
                if (b == 0)
                    return a;
                if ((~a & 1) != 0)
                {
                    if ((b & 1) != 0)
                        return SteinAlgorithm(a >> 1, b);
                    else
                        return SteinAlgorithm(a >> 1, b >> 1) << 1;
                }
                if ((~b & 1) != 0)
                    return SteinAlgorithm(a, b >> 1);
                if (a > b)
                    return SteinAlgorithm((a - b) >> 1, b);
                return SteinAlgorithm((b - a) >> 1, a);
            }

        }
    }


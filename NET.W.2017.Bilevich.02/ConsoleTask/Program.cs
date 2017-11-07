using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindNextBiggerNumber;
using FilterDigit;

namespace ConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSource = 8;
            int numberIn = 15;
            int i = 3;
            int j = 8;

            //8 - 3 + 1 = 6;


            const int size = 32;
            int count = j - i + 1;

            uint mask = (uint)((~0) << size - count) >> size - count << i;


            //var fir = (~0);
            //Console.WriteLine(fir);

            //var sec = (size - count);
            //Console.WriteLine(sec);

            //var th = (uint)(fir << sec);
            //Console.WriteLine(th);

            //var four = size - count;
            //Console.WriteLine(four);

            //var five = th << four;
            //Console.WriteLine(five);

            //var six = five << i;
            //Console.WriteLine(six);

            //Console.WriteLine(InsertNumber(8, 15, 8, 3));

            //if ("1"!="5") { }
            //Console.WriteLine(FindNextBiggerNumber(1243));
            //int[] array = new int[5];
            //List<int> numbers = new List<int>() { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            //Task4 cl = new Task4();
            //List<int> nums = cl.FilterDigit(numbers, 7);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item + ", ");

            //  Console.WriteLine(cl.FindNextBiggerNumber(-990));
            //}

        //[TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        //[TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        //[TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        //[TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        //[TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        //[TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        //[TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        //[TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        //[TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]

            Console.WriteLine(FindNthRoot(8.00, 3.00, 0.001));
            Console.WriteLine(FindNthRoot(0.0279936, 7.00, 0.0001));
            Console.WriteLine();
            Console.WriteLine(FindNthRoot(0.004241979, 9.00, 0.00000001));
            Console.WriteLine(FindNthRoot(0.04100625, 4.00, 0.0001));

        }
           public static double Pow(double a, int pow)
            {
                double result = 1;
                for (int i = 0; i < pow; i++) result *= a;
                return result;
            }

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

        public static double FindNthRoot(double a, int n, double prec)
        {
            if ((prec < 0) || (n < 0))
            {
                throw new ArgumentOutOfRangeException("Incorrect prec.");
            }
            double supposition = Math.Round((a / n), 6);
            double result = supposition;
            result = ((n - 1) * result + (a / Math.Pow(result, n - 1))) / n;
            while (Math.Abs(result - supposition) > prec)
            {
                supposition = result;
                result = ((n - 1) * result + (a / Math.Pow(result, n - 1))) / n;
            }

            int accuracy = 1;
            double tempprec = prec;
            while (tempprec < 1)
            {
                accuracy *= 10;
                tempprec *= 10;
            }

            return Math.Floor((result * accuracy + 0.1)) / accuracy;
        }
    }
    }
      


        

    

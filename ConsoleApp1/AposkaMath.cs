using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AposkaMath
    {
        public const decimal e = 2.7182818284590452353602874713m;
        public const decimal pi = 3.141592653589793238462643383m;
        public const double EPSILON = 1.0e-15;
        public static decimal pow(decimal num, int pow)
        {
            decimal res = 1;
            for (int i = 1; i <= pow; i++)
                res *= num;
            return res;
        }

        public static int fact(int num)
        {
            int res = 1;
            for (int i = num; i > 0; i--)
            {
                res *= i;
            }
            return res;
        }


        public static decimal piCalc(int steps)
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            decimal pie = 0;
            decimal a = 2;
            decimal b = 3;
            decimal c = 4;
            decimal e = 1;

            for (decimal f = (e += 1); f < steps; f++)
            {
                pie += 4 / (a * b * c);
                a += 2;
                b += 2;
                c += 2;
                pie -= 4 / (a * b * c);
                a += 2;
                b += 2;
                c += 2;
                e += 1;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Calc Time {0}", ts);
            pie += 3;
            return pie;
        }
        public static decimal sqrt(int num, int level)
        {
            decimal x = 0; ;
            for (int i = 1; i < 1000; i++)
            {
                if (i == 1)
                {
                    x = i - (sqrtf(i, num, level) / sqrtdf(i, num));
                }
                else
                {
                    x = x - (sqrtf(x, num, level) / sqrtdf(x, num));
                }
            }
            return x;
        }
        public static decimal sqrtf(decimal x, int num, int level)
        {
            decimal res = 1;
            for (int i = 1; i <= level; i++)
            { res *= x; }
            return res - num;//Formula
        }

        public static decimal sqrtdf(decimal x, int num)
        {
            return 3 * x * x;//Formula derivative
        }
        public static double abs(double x)
        {
            if (x < 0)
                return x * -1;
            else
                return x;
        }

        public static int round(double x)
        {
            return Convert.ToInt32(x);
        }

        public static decimal max(decimal x1, decimal x2)
        {
            if (x1 > x2)
                return x1;
            else
                return x2;
        }

        public static decimal min(decimal x1, decimal x2)
        {
            if (x1 < x2)
                return x1;
            else
                return x2;
        }

        public static string ix(string formula, char d)
        {
            decimal a = Convert.ToDecimal(formula.Split(d)[0]);
            decimal b = Convert.ToDecimal(formula.Split('^')[1]);
            decimal newB = b + 1;
            decimal newA = a / newB;
            return newA.ToString() + "x^" + newB.ToString();
        }

        public static string dx(string formula, char d)
        {
            decimal a = Convert.ToDecimal(formula.Split(d)[0]);
            decimal b = Convert.ToDecimal(formula.Split('^')[1]);
            decimal newA = a * b;
            decimal newB = b - 1;
            return newA.ToString() + "x^" + newB.ToString();
        }
    }
}

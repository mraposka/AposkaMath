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
        public static int bolge = 1;
        public decimal baseValue = 1.75M;
        public decimal expValue = 1 / 252M;

        public const int ITERATIONS = 27;

        // power series
        public static decimal exp(decimal power)
        {
            decimal result=Convert.ToDecimal(Math.Pow(Convert.ToDouble(AposkaMath.e), Convert.ToDouble(power)));
            return result;
        } 

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
                Console.WriteLine(x);
            }
            return x;
        }
        public static Int64 round(decimal value)
        {
            string val = value.ToString();
            if (value >= 0)
            {

                if (val.Split('.').Length > 1)
                {
                    string a = val.Split('.')[1][0].ToString() + val.Split('.')[1][1].ToString();
                    if (Convert.ToInt32(a.ToString()) > 50)
                    { return Convert.ToInt64(val.Split('.')[0]) + 1; }
                    else { return Convert.ToInt64(val.Split('.')[0]); }

                }
                else
                    return Convert.ToInt64(value);
            }
            else
            {
                if (val.Split('.').Length > 1)
                {
                    string a = val.Split('.')[1][0].ToString() + val.Split('.')[1][1].ToString();
                    if (Convert.ToInt32(a.ToString()) > 50)
                    { return Convert.ToInt64(val.Split('.')[0]); }
                    else { return Convert.ToInt64(val.Split('.')[0]) - 1; }

                }
                else
                    return Convert.ToInt64(value);
            }
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

        public static decimal cd(int q)
        {
            return Convert.ToDecimal(q);
        }
        public static Int64 floor(decimal value)
        {
            if (value >= 0)
            {

                string val = value.ToString();
                if (val.Split('.').Length > 1)
                    return Convert.ToInt64(val.Split('.')[0]);
                else
                    return Convert.ToInt64(value);
            }
            else
            {

                string val = value.ToString();
                if (val.Split('.').Length > 1)
                    return Convert.ToInt64(val.Split('.')[0]) - 1;
                else
                    return Convert.ToInt64(value);
            }
        }

        public static Int64 ceiling(decimal value)
        {
            if (value >= 0)
            {

                string val = value.ToString();
                if (val.Split('.').Length > 1)
                    return Convert.ToInt64(val.Split('.')[0]) + 1;
                else
                    return Convert.ToInt64(value);
            }
            else
            {

                string val = value.ToString();
                if (val.Split('.').Length > 1)
                    return Convert.ToInt64(val.Split('.')[0]);
                else
                    return Convert.ToInt64(value);
            }
        }

        public static bool prime(int sayi)
        {
            int sayac = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static double Log(double Power, double Base)//Check
        {
            double Whole, N, Sign;
            Sign = 1.0;

            if (Power <= 1.0 || Base <= 1.0)
            {
                if (Power <= 0.0 || Base <= 0.0)
                {
                    return double.NaN;
                }
                if (Power < 1.0)
                {
                    Power = 1.0 / Power;
                    Sign *= -1.0;
                }
                if (Base < 1.0)
                {
                    Sign *= -1.0;
                    Base = 1.0 / Base;
                }
                if (Power == 1.0)
                {
                    if (Base != 1.0)
                    {
                        return 0.0;
                    }
                    return 1.0;
                }
            }

            Whole = Power;
            N = 0.0;

            while (Whole >= Base)
            {
                Whole /= Base;
                N++;
            }
            if (Whole == 1.0)
            {
                return (Sign * N);
            }
            return Sign * (N + (1.0 / Log(Base, Whole)));
        }

        private static decimal angleCheck(decimal angle)
        {
            do
            {
                if (angle >= 360)
                {
                    angle -= 360;
                }
            } while (angle >= 360);
            return angle;
        }

        private static decimal angletolower(decimal angle, char func)
        { 
            if (angle<=360)
            {
                //Bölge
                if (func == 's')
                {
                    if (angle >= 0 && angle <= 180)
                    {
                        bolge = 1;
                    }
                    else if (angle >= 180 && angle <= 360)
                    {
                        bolge = -1;
                    }
                }
                else if (func == 'c')
                {
                    if (angle >= 90 && angle <= 270)
                    {
                        bolge = -1;
                    }
                    else if (angle >= 0 && angle <= 270 || angle >= 0 && angle <= 360)
                    {
                        bolge = 1;
                    }
                }
                //Bölge
                do
                {
                    if (angle >= 270 && angle <= 360)
                    {
                        angle = 360 - angle;
                    }
                    if (angle >= 180 && angle <= 270)
                    {
                        angle = angle - 180;
                    }
                    if (angle >= 90 && angle <= 180)
                    {
                        angle = 180 - angle;
                    }
                } while (angle > 90);
            }
            else
            {
                angle -= 360;
                angletolower(angle,func);
            }
            return angle;
        }

        public static decimal sine(decimal angle)
        {
            //angle to radian convert  
            angle = angleCheck(angle);
            angle = angletolower(angle,'s');
            angle = angle / 180 * AposkaMath.pi;
            int sayac = 1; decimal binomial = 0; decimal sin = 0;
            for (int i = 3; i < 8; i += 2)
            {
                if (sayac % 2 != 0)
                { binomial += Convert.ToDecimal(AposkaMath.pow(angle, i) / Convert.ToDecimal(fact(i))) * -1; }
                else
                { binomial += Convert.ToDecimal(AposkaMath.pow(angle, i) / Convert.ToDecimal(fact(i))); }

                sin = angle + binomial;
                sayac++;
            }
            return bolge * sin;
        }
        public static decimal cose(decimal angle)
        {
            //angle to radian convert
            angle = angleCheck(angle);
            angle = angletolower(angle, 'c'); 
            angle = angle / 180 * AposkaMath.pi;
            int sayac = 1; decimal binomial = 0; decimal sin = 0;
            for (int i = 2; i < 7; i += 2)
            {
                if (sayac % 2 == 0)
                { binomial += Convert.ToDecimal(AposkaMath.pow(angle, i) / Convert.ToDecimal(fact(i))) * -1; }
                else
                { binomial += Convert.ToDecimal(AposkaMath.pow(angle, i) / Convert.ToDecimal(fact(i))); }


                sayac++;
            }
            sin = 1 - binomial; 
            return bolge * sin; 
        }
        public static decimal tan(decimal angle)
        {
            decimal sine = AposkaMath.sine(angle);
            decimal cose = AposkaMath.cose(angle);
            decimal tan = sine / cose;
            return tan;
        }
        public static decimal cot(decimal angle)
        {
            decimal sine = AposkaMath.sine(angle);
            decimal cose = AposkaMath.cose(angle);
            decimal cot = cose / sine;
            return cot;
        }

        public static decimal getDigitAfterPoint(decimal num,int digitNum)
        { 
            if (num >= 0) {
                try
                {
                string numToStr = num.ToString();
                string newNumStr = numToStr.Substring(0, digitNum + 2);
                    num= Convert.ToDecimal(newNumStr);
                    if (num == 0.999m)
                    {
                        return 1m;
                    }
                    else if (num == 0.000m)
                    {
                        return 0m;
                    }
                    else if (num == 1.000m)
                    {
                        return 1m;
                    }
                    else if (num == 0.499m)
                    {
                        return 0.5m;
                    } 
                    return Convert.ToDecimal(newNumStr);
                }
                catch (Exception)
                {
                    return num;
                } 
            }
            else {
                try
                {
                    string numToStr = num.ToString();
                    string newNumStr = numToStr.Substring(0, digitNum + 3);
                    num = Convert.ToDecimal(newNumStr);
                    if (num == -0.999m)
                    {
                        return -1m;
                    }
                    else if (num == -0.000m)
                    {
                        return 0m;
                    }
                    else if (num == -1.000m)
                    {
                        return -1m;
                    }
                    else if (num == -0.499m)
                    {
                        return -0.5m;
                    }
                    return Convert.ToDecimal(newNumStr);
                }
                catch (Exception)
                {
                    return num;
                }
            }
            
        }

        public static decimal arcsin(decimal value)
        {
            for(int i = 0; i <= 360;i++)
            {
                if(AposkaMath.getDigitAfterPoint(Convert.ToDecimal(AposkaMath.sine(i)), 3) == AposkaMath.getDigitAfterPoint(value,3))
                {
                    return i;
                }
            }
            Console.WriteLine("unknown results");
            return 0;
        }

        public static decimal arccos(decimal value)
        {
            for (int i = 0; i <= 360; i++)
            {
                if (AposkaMath.getDigitAfterPoint(Convert.ToDecimal(AposkaMath.cose(i)), 3) == AposkaMath.getDigitAfterPoint(value, 3))
                {
                    return i;
                }
            }
            Console.WriteLine("unknown results");
            return 0;
        }
        public static decimal cosh(decimal angle)
        {
            decimal cosh_val = Convert.ToDecimal(Math.Pow(Convert.ToDouble(AposkaMath.e), Convert.ToDouble(angle)) + Math.Pow(Convert.ToDouble(AposkaMath.e), Convert.ToDouble(-1 * angle)));
            return cosh_val / 2;
        }
        public static decimal sinh(decimal angle)
        {
            decimal cosh_val = Convert.ToDecimal(Math.Pow(Convert.ToDouble(AposkaMath.e), Convert.ToDouble(angle)) - Math.Pow(Convert.ToDouble(AposkaMath.e), Convert.ToDouble(-1 * angle)));
            return cosh_val / 2;
        }
        public static decimal tanh(decimal angle)
        {
            decimal cosh = AposkaMath.cosh(angle);
            decimal sinh = AposkaMath.sinh(angle);
            return sinh / cosh;
        }
        public static decimal coth(decimal angle)
        {
            decimal tanh = AposkaMath.tanh(angle);
            return 1 / tanh;
        }
        public static decimal sech(decimal angle)
        {
            decimal cosh = AposkaMath.cosh(angle);
            return 1 / cosh;
        }
        public static decimal csch(decimal angle)
        {
            decimal sinh = AposkaMath.sinh(angle);
            return 1 / sinh;
        }
       /* public static decimal atan2(decimal x,decimal y)
        {
            if (x > 0)
            {
                return Convert.ToDecimal(2 * Math.Atan(Convert.ToDouble(Convert.ToDouble(y) / Math.Sqrt(Convert.ToDouble(x * x + y * y)) + Convert.ToDouble(x))));
            }
            else if (x <= 0 && y != 0)
            {
                return Convert.ToDecimal(2 * Math.Atan(Math.Sqrt(Convert.ToDouble(x * x + y * y)) - Convert.ToDouble(x) / Convert.ToDouble(Convert.ToDouble(y) )));
            }
            else if (x < 0m && y == 0m)
            {
                return AposkaMath.pi;
            }
            else if(x==0m && y == 0m)
            {
                return 0;
            }
            return 0m;
        }*/
        public static long bigMul(int a,int b)
        {
            return Convert.ToInt64(a * b);
        }
        public static int remainder(int a,int b)
        {
            if (a > b)
                return a % b;
            else if (a < b)
                return b % a;
            else
                return 0;
        }
        public static int div(int a, int b)
        {
            if (a > b)
                return a / b;
            else if (a < b)
                return b / a;
            else
                return 1;
        }
    }
}

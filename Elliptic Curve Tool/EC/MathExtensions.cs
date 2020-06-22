using System;
using System.Collections.Generic;

namespace EllipticCurveTool.EC
{
    public static class MathExtensions
    {
        /// <summary>
        /// Number of digits when rounding
        /// </summary>
        private const int DIGITS = 3;

        /// <summary>
        /// Calculates <paramref name="number"/> mod <paramref name="modulus"/>
        /// In contrast to default CSharp implementation no negative results are returned
        /// </summary>
        public static int Mod(this int number, int modulus)
        {
            int result = number % modulus;
            while (result < 0)
            {
                result += modulus;
            }

            return result;
        }


        /// <summary>
        /// Calculates <paramref name="number"/> mod <paramref name="modulus"/>
        /// In contrast to default CSharp implementation no negative results are returned
        /// </summary>
        public static double Mod(this double number, int modulus)
        {
            double result = number % modulus;
            while (result < 0)
            {
                result += modulus;
            }

            return result;
        }

        /// <summary>
        /// Calculate the multiplicative inverse of a number respective the given modulus by simple brute force.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="modulus"></param>
        /// <returns>0 if number has no multiplicative inverse</returns>
        public static int MultInv(this int number, int modulus)
        {

            if (number == 0)
            {
                // ECPoint is at infinity
                return 0;
            }

            number = number.Mod(modulus);

            for (int i = 1; i < modulus; i++)
            {
                if ((number * i).Mod(modulus) == 1)
                    return i;
            }

            // No multiplicative inverse present
            return 0;
        }

        /// <summary>
        /// Check whether a number is prime by using trial division https://www.wikiwand.com/en/Trial_division.
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns><c>true</c> if number is prime, else <c>false</c></returns>
        public static bool IsPrime(this int number)
        {
            if (number == 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int upperBound = (int)Math.Sqrt(number) + 1;

            for (int i = 3; i <= upperBound; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Solve a reduced cubic equation 0 = x³ + px + q nach x and return real roots as a list.
        /// see https://www.wikiwand.com/en/Cubic_function#/Cardano's_method
        /// The smallest root will be at first place in the list
        /// </summary>
        /// <param name="p">Parameter p of the equation</param>
        /// <param name="q">Parameter q of the equation</param>
        /// <returns>Real valued roots of the equation</returns>
        public static List<double> SolveReducedCubicEquation(double p, double q)
        {
            double D = q * q / 4 + p * p * p / 27;

            List<double> result = new List<double>();

            if (D < 0)
            {
                // casus irreducibils
                double x1 = Math.Sqrt(-4.0 / 3.0 * p) * Math.Cos(1.0 / 3.0 * Math.Acos(-q / 2 * Math.Sqrt(-27 / (p * p * p))));
                double x2 = -Math.Sqrt(-4.0 / 3.0 * p) * Math.Cos(1.0 / 3.0 * Math.Acos(-q / 2 * Math.Sqrt(-27 / (p * p * p))) + Math.PI / 3);
                double x3 = -Math.Sqrt(-4.0 / 3.0 * p) * Math.Cos(1.0 / 3.0 * Math.Acos(-q / 2 * Math.Sqrt(-27.0 / (p * p * p))) - Math.PI / 3);
                result.Add(x1);
                result.Add(x2);
                result.Add(x3);
                result.Sort();
                return result;
            }
            double u, v;
            if (-q / 2 + Math.Sqrt(D) > 0)
                u = Math.Pow(-q / 2 + Math.Sqrt(D), 1.0 / 3.0);
            else
                u = -Math.Pow(System.Math.Abs(-q / 2 + Math.Sqrt(D)), 1.0 / 3.0);

            if (Math.Pow(-q / 2 - Math.Sqrt(D), 1.0 / 3.0) > 0)
                v = Math.Pow(-q / 2 - Math.Sqrt(D), 1.0 / 3.0);
            else
                v = -Math.Pow(Math.Abs(-q / 2 - Math.Sqrt(D)), 1.0 / 3.0);

            if (D > 0)
            {
                result.Add(u + v);
                return result;
            }

            // Else D=0
            result.Add(2 * u);
            if (!result.Contains(-u))
                result.Add(-u);
            result.Sort();
            return result;
        }

        /// <summary>
        /// Round a number to DIGITS and return the result as string.
        /// </summary>
        /// <param name="number">Number to be rounded</param>
        /// <returns>Rounded number as string</returns>
        public static string RoundStr(this double number)
        {
            double rounded = Math.Round(number, DIGITS, MidpointRounding.AwayFromZero);
            return rounded.ToString();
        }

        /// <summary>
        /// Gets the binary representation of a given decimal number.
        /// For negative decimal numbers the binary representation of the absolute value is returned.
        /// </summary>
        /// <param name="number">The decimal number to be converted</param>
        /// <returns>Binary representation of <paramref name="number"/> as string</returns>
        public static string GetDualNumber(this int number)
        {
            string result = String.Empty;
            number = Math.Abs(number);

            // Iterate over bits 0 to 31
            for (int i = 0; i < 32; i++)
            {
                result = (number & 1) + result;
                number >>= 1;
            }

            // Remove leading zeros
            int start = result.Length - 1;

            for (int i = 0; i <= start; i++ )
            {
                if (result[i] == '0') continue;

                start = i;
                break;
            }

            result = result.Substring(start);

            return result;
        }
    }
}

using System;
using System.Collections.Generic;

namespace EllipticCurveTool.EC
{
    /// <summary>
    /// An elliptic curve y² = x³ + a*x + b mod p over the ring Z_p
    /// </summary>
    public class EllipticCurveZ : EllipticCurve
    {
        private int p;
        /// <summary>
        /// equiv sign
        /// </summary>
        private const char Equiv = '\u2261';


        /// <summary>
        /// Parameter p of elliptic curve y² = x³ + a*x + b mod p.
        /// </summary>
        public int P
        {
            get { return p; }
        }

        public EllipticCurveZ(int a, int b, int p)
        {
            this.a = a;
            this.b = b;
            this.p = p;

            Xmin = 0;
            Ymin = 0;
            Xmax = p - 1;
            Ymax = p - 1;


            points = new List<ECPoint>();

            for (int x = 0; x < p; x++)
                for (int y = 0; y < p; y++)
                    if ((x * x * x + a * x + b).Mod(p) == (y * y).Mod(p))
                        points.Add(new ECPoint(x, y));

            points.Add(new ECPoint()); // ECPoint 0 at infinity
        }

        public override ECPoint Add(ECPoint p1, ECPoint p2)
        {
            AdditionLog = "Curve: " + this;
            AdditionLog += "\n\nR = " + p1 + " + " + p2;
            int s;
            int x1 = (int)p1.X;
            int x2 = (int)p2.X;
            int y1 = (int)p1.Y;
            int y2 = (int)p2.Y;
            if (p2.IsInfinity)
            {
                AdditionLog += " = " + p1;
                return p1;
            }

            if (p1.IsInfinity)
            {
                AdditionLog += " = " + p2;
                return p2;
            }

            if (p1.Equals(p2))
            {
                // Point doubling
                int inv = (2*y1).MultInv(p);
                if (inv == 0)
                {
                    // ECPoint is at infinity
                    AdditionLog += " = " + new ECPoint();
                    return new ECPoint();
                }
                s = ((3 * x1 * x1 + a) * inv).Mod(p);
                AdditionLog += "\n\ns " + Equiv + " (3*x_1² + a) * (2*y_1)^-1 mod p";
                AdditionLog += "\ns " + Equiv + " (3*" + x1 + "²" + " + " + a + ") * (2*" + y1 + ")^-1 mod " + p;
                AdditionLog += "\ns " + Equiv + " " + (3 * x1 * x1 + a) + " * " + (2 * y1).MultInv(p) + " mod " + p;
                AdditionLog += "\ns " + Equiv + " " + s;
            }
            else
            {
                // Normal Addition
                int inv = (x2 - x1).MultInv(p);
                if (inv == 0)
                {
                    // ECPoint is at infinity
                    AdditionLog += " = " + new ECPoint();
                    return new ECPoint();
                }
                s = ((y2 - y1) * inv).Mod(p);
                AdditionLog += "\n\ns " + Equiv + " (y_2 - y_1) * (x_2 - x_1)^-1 mod p";
                AdditionLog += "\ns " + Equiv + " (" + y2 + " - " + y1 + ") * (" + x2 + " - " + x1 + ")^-1 mod " + p;
                AdditionLog += "\ns " + Equiv + " " + (y2 - y1) + " * " + inv + " mod " + p;
                AdditionLog += "\ns " + Equiv + " " + s;
            }

            int x3 = (s * s - x1 - x2).Mod(p);
            AdditionLog += "\n\nx_3 " + Equiv + " s² - x_1 - x_2 mod p";
            AdditionLog += "\nx_3 " + Equiv + " " + s + "² - " + x1 + " - " + x2 + " mod " + p;
            AdditionLog += "\nx_3 " + Equiv + " " + x3;

            int y3 = (s * (x1 - x3) - y1).Mod(p);
            AdditionLog += "\n\ny_3 " + Equiv + " s*(x_1 - x_3) - y_1 mod p";
            AdditionLog += "\ny_3 " + Equiv + " " + s + "*(" + x1 + " - " + x3 + ") - " + y1 + " mod " + p;
            AdditionLog += "\ny_3 " + Equiv + " " + y3;

            ECPoint result = new ECPoint(x3, y3);
            AdditionLog += "\n\nR = " + result;
            return result;
        }

        public override string ToString()
        {
            string result = "y² " + Equiv + " x³ + ";
            if (a != 1)
                result += a;
            result += "x + " + b + " mod " + p;
            return result;
        }

        public string PrintPoints()
        {
            string result = string.Empty;
            if (points == null)
                return result;

            for (int i = 0; i < points.Count; i++)
            {
                ECPoint point = points[i];
                result += "P" + (i + 1) + " = " + point;
                if (i < points.Count - 1)
                    result += Environment.NewLine;
            }
            return result;
        }

        public override void Draw(CoordinateSystem coordSys)
        {
            foreach (ECPoint ecPoint in Points)
                coordSys.DrawECPoint(ecPoint);
        }
    }
}

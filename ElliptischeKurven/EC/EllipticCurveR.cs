using System;
using System.Collections.Generic;
using System.Drawing;

namespace EllipticCurves.EC
{
    /// <summary>
    /// An elliptic curve y² = x³ + a*x + b over the real numbers R
    /// </summary>
    public class EllipticCurveR : EllipticCurve
    {
        private const int PRECISION = 3;
        private readonly int discriminant;
        private readonly List<double> roots; 

        /// <summary>
        /// This list will be filled on demand. 
        /// If discrimant D > 0 the curve splits into two curves,
        /// in this case the points of the left curve part will be stored here.
        /// If the curve does not fall into two subcurves this list remains empty.
        /// </summary>
        private List<ECPoint> pointsLeft = new List<ECPoint>();

        public EllipticCurveR(int a, int b, int? xmax=null)
        {
            this.a = a;
            this.b = b;
            roots = MathExtensions.SolveReducedCubicEquation(a, b);

            // most left root for determining Xmin
            double root = roots[0];
            if (root < 0 && (root - (int)root) != 0)
                root--;

            Xmin = Math.Min(0, (int)root); // Ensure CoordinateSystem starts with 0
            
            if (xmax is null)
            {
                Xmax = Math.Max(1, Xmin + 5);
            }
            else
            {
                Xmax = (int)xmax;
            }
                
            discriminant = -(4 * a * a * a + 27 * b * b);

            GetPoints();
        }

        /// <summary>
        /// Determine points on elliptic curve and store them in points list
        /// </summary>
        private void GetPoints()
        {
            points = new List<ECPoint>();

            Ymin = int.MaxValue;
            Ymax = int.MinValue;

            if (discriminant < 0)
            {
                // Graph does not fall into two parts
                SetPointsForSingleComponentCurve(Xmin);
            }
            else if (discriminant > 0)
            {
                // Graph falls into two parts
                SetPointsForTwoComponentCurve();
            }
            else
            {
                // discriminant is 0
                if (roots.Count == 1)
                {
                    // Just one root -> sharp edge in a single curve
                    SetPointsForSingleComponentCurve(Xmin);
                }
                else
                {
                    // two different roots -> check if there is an isolated ECPoint among them
                    double leftRoot = roots[0];
                    double rightRoot = roots[1];

                    if (IsIsolated(leftRoot) && Xmax >= rightRoot)
                    {
                        double xmin = (int) (leftRoot) + 1;
                        pointsLeft.Add(new ECPoint(leftRoot, 0));
                        SetPointsForSingleComponentCurve(xmin); // draw right curve normally
                    }
                    else if (IsIsolated(rightRoot) && rightRoot <= Xmax)
                    {
                        double xmax = (int)(rightRoot) - 1;
                        points.Add(new ECPoint(rightRoot, 0));
                        SetPointsForSingleComponentCurve(xmax, true); // draw left curve normally
                    }
                    else
                    {
                        // No isolated points, we can draw the curve normally
                        SetPointsForSingleComponentCurve(Xmin);
                    }
                }
            }

            Ymin = -Ymax;

            points.Add(new ECPoint()); // ECPoint 0 at infinity
        }

        /// <summary>
        /// Check if the given root lays isolated in the graph
        /// </summary>
        /// <param name="root">the root to check</param>
        /// <returns><c>true</c> if root lays isolated else <c>false</c></returns>
        private bool IsIsolated(double root)
        {
            double stepsize = Math.Pow(10, -PRECISION);
            double x1 = root - stepsize;
            double x2 = root + stepsize;
            double ySquare1 = x1 * x1 * x1 + a * x1 + b;
            double ySquare2 = x2 * x2 * x2 + a * x2 + b;

            return ySquare1 < 0 && ySquare2 < 0;
        }

        private void SetPointsForTwoComponentCurve()
        {
            double secondRoot = roots[1];
            double thirdRoot = roots[2];

            double stepsize = Math.Pow(10, -PRECISION);
            List<ECPoint> pointsBelow = new List<ECPoint>();

            bool rightCurve = true;
            List<ECPoint> pointsBelowLeft = new List<ECPoint>();
            for (double x = Xmax; x >= Xmin; x -= stepsize)
            {
                x = Math.Round(x, PRECISION);
                double ySquare = x * x * x + a * x + b;

                if (ySquare < 0)
                    continue;

                double y = Math.Sqrt(ySquare);
                if (y > Ymax)
                    Ymax = (int)y;

                if (x <= thirdRoot && rightCurve)
                {
                    // Finish right curve and switch to left curve
                    pointsLeft.Add(new ECPoint(x, 0));
                    pointsBelowLeft.Add(new ECPoint(x, -y));
                    pointsLeft.Add(new ECPoint(secondRoot, 0));
                    rightCurve = false;
                    continue;
                }

                if (rightCurve)
                {
                    points.Add(new ECPoint(x, y));
                    pointsBelow.Add(new ECPoint(x, -y));
                }
                else
                {
                    pointsLeft.Add(new ECPoint(x, y));
                    pointsBelowLeft.Add(new ECPoint(x, -y));
                }
            }
            // Create the two curve components by merging upper and lower parts
            pointsBelow.Reverse();
            pointsBelowLeft.Reverse();
            points.AddRange(pointsBelow);
            pointsLeft.AddRange(pointsBelowLeft);
        }


        private void SetPointsForSingleComponentCurve(double xmin, bool useLeftCurve=false)
        {
            double stepsize = Math.Pow(10, -PRECISION);
            List<ECPoint> pointsBelow = new List<ECPoint>();
            for (double x = Xmax; x >= xmin; x -= stepsize)
            {
                x = Math.Round(x, PRECISION);
                double ySquare = x * x * x + a * x + b;

                if (ySquare < 0)
                    continue;

                double y = Math.Sqrt(ySquare);
                if (y > Ymax)
                    Ymax = (int)y;

                if (useLeftCurve)
                {
                    pointsLeft.Add(new ECPoint(x, y));
                }
                else
                {
                    points.Add(new ECPoint(x, y));
                }
                
                if (y != 0)
                    pointsBelow.Add(new ECPoint(x, -y));
            }
            pointsBelow.Reverse();

            if (useLeftCurve)
            {
                pointsLeft.AddRange(pointsBelow);
            }
            else
            {
                points.AddRange(pointsBelow);
            }
            
        }

        public override ECPoint Add(ECPoint p1, ECPoint p2)
        {
            AdditionLog = "Curve: " + this;
            AdditionLog += "\n\nR = " + p1 + " + " + p2;

            double s;
            double x1 = p1.X;
            double x2 = p2.X;
            double y1 = p1.Y;
            double y2 = p2.Y;
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
                // see https://www.wikiwand.com/en/Elliptic_curve
                if (y1.Equals(0))
                {
                    AdditionLog += " = " + new ECPoint();
                    return new ECPoint(); // P is self inverse --> Result is ECPoint at infinity
                }

                // Point doubling
                s = (3 * x1 * x1 + a) / (2 * y1);
                AdditionLog += "\n\ns = (3*x_1² + a) / (2*y_1)";
                AdditionLog += "\ns = (3*" + x1.RoundStr() + "²" + " + " + a + ") / (2*" + y1.RoundStr() + ")";
                AdditionLog += "\ns = " + s.RoundStr();
            }
            else
            {
                // Normal Addition
                double xDiff = (x2 - x1);
                if (xDiff.Equals(0))
                {
                    //ECPoint is at infinity
                    AdditionLog += " = " + new ECPoint();
                    return new ECPoint();
                }
                s = (y2 - y1) / xDiff;
                AdditionLog += "\n\ns = (y_2 - y_1) / (x_2 - x_1)";
                AdditionLog += "\ns = (" + y2.RoundStr() + " - " + y1.RoundStr() + ") / (" + x2.RoundStr() + " - " + x1.RoundStr() + ")";
                AdditionLog += "\ns = " + s.RoundStr();
            }

            double x3 = s * s - x1 - x2;
            AdditionLog += "\n\nx_3 = s² - x_1 - x_2";
            AdditionLog += "\nx_3 = " + s.RoundStr() + "² - " + x1.RoundStr() + " - " + x2.RoundStr();
            AdditionLog += "\nx_3 = " + x3.RoundStr();

            double y3 = s * (x1 - x3) - y1;
            AdditionLog += "\n\ny_3 = s*(x_1 - x_3) - y_1";
            AdditionLog += "\ny_3 = " + s.RoundStr() + "*(" + x1.RoundStr() + " - " + x3.RoundStr() + ") - " + y1.RoundStr();
            AdditionLog += "\ny_3 = " + y3.RoundStr();

            ECPoint result = new ECPoint(x3, y3);
            AdditionLog += "\n\nR = " + result;
            return result;
        }


        public override void Draw(CoordinateSystem coordSys)
        {
            List<Point> pixelPoints = new List<Point>();

            foreach (ECPoint ecPoint in points)
            {
                if (ecPoint.IsInfinity)
                    continue;
                Tuple<double, double> pixelCoord = coordSys.GetPixelCoordinates(ecPoint.X, ecPoint.Y);
                int xP = (int)Math.Round(pixelCoord.Item1);
                int yP = (int)Math.Round(pixelCoord.Item2);
                pixelPoints.Add(new Point(xP, yP));
            }

            List<Point> pixelPointsLeft = new List<Point>();
            if (pointsLeft.Count > 0)
            {
                foreach (ECPoint ecPoint in pointsLeft)
                {
                    if (ecPoint.IsInfinity)
                        continue;
                    Tuple<double, double> pixelKoord = coordSys.GetPixelCoordinates(ecPoint.X, ecPoint.Y);
                    int xP = (int)Math.Round(pixelKoord.Item1);
                    int yP = (int)Math.Round(pixelKoord.Item2);
                    pixelPointsLeft.Add(new Point(xP, yP));
                }
            }

            coordSys.DrawCurve(pixelPoints.ToArray());

            if (pixelPoints.Count > 0)
                coordSys.DrawCurve(pixelPointsLeft.ToArray());
        }

        public void DrawAddition(ECPoint summand1, ECPoint summand2, CoordinateSystem coordSys)
        {
            if (summand1 == null || summand2 == null || coordSys == null)
                return;

            ECPoint result = this.Add(summand1, summand2);

            ECPoint minusResult = new ECPoint(result.X, -result.Y);

            double distance1 = (summand1.X - minusResult.X) * (summand1.X - minusResult.X)
                              + (summand1.Y - minusResult.Y) * (summand1.Y - minusResult.Y);

            double distance2 = (summand2.X - minusResult.X) * (summand2.X - minusResult.X)
                              + (summand2.Y - minusResult.Y) * (summand2.Y - minusResult.Y);

            ECPoint start = distance1 > distance2 ? summand1 : summand2;

            if (result.IsInfinity) return;

            coordSys.DrawLine(Color.RoyalBlue, start, minusResult);
            coordSys.SetMinusResult(minusResult);
            coordSys.DrawDashedLine(Color.RoyalBlue, minusResult, result);
        }


        public void DrawDoubling(ECPoint ecPoint, CoordinateSystem ks)
        {
            if (ecPoint == null || ks == null)
                return;

            ECPoint result = this.Add(ecPoint, ecPoint);

            if (result.IsInfinity) return;

            ECPoint minusResult = new ECPoint(result.X, -result.Y);
            ks.DrawLine(Color.RoyalBlue, ecPoint, minusResult);
            ks.SetMinusResult(minusResult);

            // Prolong tangent in other direction
            double m = (ecPoint.Y - minusResult.Y)/(ecPoint.X - minusResult.X);
            double n = minusResult.Y - m*minusResult.X;
            ECPoint tangentPoint = new ECPoint(-minusResult.X, m*(-minusResult.X)+n);
            ks.DrawLine(Color.RoyalBlue, ecPoint, tangentPoint);

            ks.DrawDashedLine(Color.RoyalBlue, minusResult, result);
            ks.SetAdditionResult(result);
        }

        public override string ToString()
        {
            string result = "y² = x³ + ";
            if (a != 1)
                result += a;
            result += "x + " + b;
            return result;
        }
    }
}

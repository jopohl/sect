using System.Collections.Generic;
using System.Drawing;

namespace EllipticCurveTool.EC
{
    /// <summary>
    /// Abstract base class for elliptic curves over R and Z_p
    /// </summary>
    public abstract class EllipticCurve
    {
        protected int a;
        protected int b;

        protected List<ECPoint> points;

        /// <summary>
        /// Parameter a of elliptic curve y² = x³ + a*x + b
        /// </summary>
        public int A
        {
            get { return a; }
        }

        /// <summary>
        /// Parameter b of elliptic curve y² = x³ + a*x + b
        /// </summary>
        public int B
        {
            get { return b; }
        }

        /// <summary>
        /// Minimal x-value for drawing curve and choosing points
        /// </summary>
        public int Xmin { get; protected set; }

        /// <summary>
        /// Maximal x-value for drawing curve and choosing points
        /// </summary>
        public int Xmax { get; set; }

        /// <summary>
        /// Minimal y-value for drawing curve and choosing points
        /// </summary>
        public int Ymin { get; protected set; }

        /// <summary>
        /// Maximal y-value for drawing curve and choosing points
        /// </summary>
        public int Ymax { get; protected set; }

        public List<ECPoint> Points
        {
            get { return points; }
        }

        /// <summary>
        /// Log for currently executed addition on the elliptic curve for display of calculation steps.
        /// Only changed in the Add method
        /// </summary>
        public string AdditionLog { get; protected set; }

        /// <summary>
        /// Log for currently executed multiplication on the elliptic curve for display of calculation steps.
        /// Only changed in the Multiply method
        /// </summary>
        public string MultiplicationLog { get; private set; }

        public abstract ECPoint Add(ECPoint p1, ECPoint p2);

        public abstract void Draw(CoordinateSystem ks);

        public ECPoint Multiply(int n, ECPoint p)
        {
            string additionLog = AdditionLog;
            MultiplicationLog = "Curve: " + this;
            MultiplicationLog += "\n\nT = " + n + " * " + p;
            MultiplicationLog += "\n\nUsing Double-and-Add Algorithm...";
            MultiplicationLog += "\nn = " + n + " = (" + n.GetDualNumber() + ")_bin";
            ECPoint result = new ECPoint();
            string nDual = n.GetDualNumber();

            MultiplicationLog += "\nInitializing T = " + result;
            MultiplicationLog += "\nGoing through the binary representation of n...";

            for (int i = 0; i < nDual.Length; i++)
            {
                MultiplicationLog += "\n\nn[" + i + "] = " + nDual[i] + ":";
                MultiplicationLog += "\nSet T = 2*T = 2*" + result;
                result = Add(result, result);
                MultiplicationLog += "\nT = " + result;
                if (nDual[i] == '1')
                {
                    MultiplicationLog += "\nSince n[" + i + "] = 1 set T = T + P";
                    MultiplicationLog += "\nT = " + result + " + " + p;
                    result = Add(result, p);
                    MultiplicationLog += "\nT = " + result;
                }

            }

            MultiplicationLog += "\n\n\nT = " + n + "*" + p + " = " + result;
            AdditionLog = additionLog;
            return result;
        }
    }
}

namespace EllipticCurves.EC
{
    /// <summary>
    /// Point on an Elliptic Curve
    /// </summary>
    public class ECPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public bool IsInfinity
        {
            get { return double.IsInfinity(X) && double.IsInfinity(Y); }
        }

        public ECPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Create a new ECPoint at infinity
        /// </summary>
        public ECPoint() : this(double.NegativeInfinity, double.NegativeInfinity) { }

        public override bool Equals(object obj)
        {
            if (!(obj is ECPoint))
                return false;

            ECPoint point = (ECPoint)obj;

            if (this.X.Equals(point.X) && this.Y.Equals(point.Y))
                return true;

            return false;
        }

        public override string ToString()
        {
            if (IsInfinity)
                return "Inf";

            return "(" + X.RoundStr() + " / " + Y.RoundStr() + ")";
        }

        public static bool operator ==(ECPoint p1, ECPoint p2)
        {
            if (p1 is null && p2 is null)
                return true;
            if (p1 is null)
                return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(ECPoint p1, ECPoint p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return (int)(X + Y);
        }
    }
}

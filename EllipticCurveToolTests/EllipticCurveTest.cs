using NUnit.Framework;
using EllipticCurveTool.EC;

namespace EllipticCurveToolTests
{
    public class EllipticCurveZTest
    {

        [Test]
        public void AddMultiplyTest()
        {
            int a = 3;
            int b = 19;
            int p = 23;
            EllipticCurveZ curve = new EllipticCurveZ(a, b, p);
            ECPoint p1 = new ECPoint(3, 3); 
            ECPoint p2 = new ECPoint(4, 7);
            ECPoint p3 = new ECPoint(3, 20);


            Assert.AreEqual(new ECPoint(19, 9), curve.Add(p1, p1));
            Assert.AreEqual(new ECPoint(13, 22), curve.Multiply(3, p1));
            Assert.AreEqual(new ECPoint(1, 0), curve.Multiply(6, p1));
            Assert.AreEqual(new ECPoint(9, 19), curve.Add(p1, p2));
            Assert.AreEqual(new ECPoint(), curve.Add(p1, p3));
        }
    }
}

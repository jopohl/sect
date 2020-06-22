using System;
using EllipticCurves.EC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EllipticCurveTests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void TestCubicSolve()
        {
            double result1 = MathExtensions.SolveReducedCubicEquation(2, 2)[0];
            Assert.AreEqual(Math.Round(result1,2),-0.77);
        }
    }
}

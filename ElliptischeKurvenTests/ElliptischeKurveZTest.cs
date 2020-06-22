using EllipticCurves.EC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ElliptischeKurvenTests
{
    
    
    /// <summary>
    ///Dies ist eine Testklasse für "ElliptischeKurveZTest" und soll
    ///alle ElliptischeKurveZTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class ElliptischeKurveZTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        ///Ein Test für "Add"
        ///</summary>
        [TestMethod()]
        public void AddiereMultipliziereTest()
        {
            int a = 3;
            int b = 19;
            int p = 23;
            EllipticCurveZ kurve = new EllipticCurveZ(a, b, p);
            ECPoint p1 = new ECPoint(3,3); 
            ECPoint p2 = new ECPoint(4,7);
            ECPoint p3 = new ECPoint(3,20);


            Assert.AreEqual(new ECPoint(19,9), kurve.Add(p1,p1));
            Assert.AreEqual(new ECPoint(13,22), kurve.Multiply(3,p1));
            Assert.AreEqual(new ECPoint(1,0), kurve.Multiply(6,p1));
            Assert.AreEqual(new ECPoint(9,19), kurve.Add(p1,p2));
            Assert.AreEqual(new ECPoint(),kurve.Add(p1,p3));
        }
    }
}

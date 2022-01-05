using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpCalculator;

namespace Caclulator_Testing
{
    [TestClass]
    public class AbsTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void AbsDouble() => Abs();
        [TestMethod]
        public void AbsString() => Abs(ToString: true);
        [TestCleanup]
        public override void Clean() => base.Clean();
        void Abs(bool ToString = false)
        {
            for (double i = -10000; i < 10000; i += 0.1)
            {

                if (ToString)
                    Assert.AreEqual<double>(memberToTest.Abs(i.ToString()), Math.Abs(i));
                else
                    Assert.AreEqual<double>(memberToTest.Abs(i), Math.Abs(i));

            }
        }
    }
}

using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclulator_Testing
{
    [TestClass]
    public class CosTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void CosDouble() => Cos();

        [TestMethod]
        public void CosString() => Cos(ToString: true);

        [TestCleanup]
        public override void Clean() => base.Clean();

        void Cos(bool ToString = false)
        {
            for (double i = 0; i < 360; i += 0.01)
            {
                double expected = Math.Cos(i);
                double actual = ToString ? memberToTest.Cos(i.ToString()) : memberToTest.Cos(i);
                Assert.AreEqual<double>(actual, expected);
            }
        }
    }
}

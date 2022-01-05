using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclulator_Testing
{
    [TestClass]
    public class SquateRootTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void SquareRootTestingToString() => SquareRoot(true);

        [TestMethod]
        public void SquareRootDouble() => SquareRoot();

        void SquareRoot(bool ToString = false)
        {
            for (double i = 1; i < 100; i += 0.01)
            {
                double expected = Math.Sqrt(i);
                double actual = ToString ? memberToTest.Sqrt( i.ToString()) : memberToTest.Sqrt(i);
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

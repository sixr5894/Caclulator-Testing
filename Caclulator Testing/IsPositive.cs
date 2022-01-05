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
    public class IsPositive : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void IsPositiveTesting()
        {
            for (double i = -1000; i < 1000; i++)
                Assert.AreEqual<bool>(memberToTest.isPositive(i), i>0);
        }

        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

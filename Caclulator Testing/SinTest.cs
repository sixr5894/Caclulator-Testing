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
    public class SinTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void SinTesting()
        {
            for (double i = 0; i <= 360; i += 0.01)
                Assert.AreEqual<double>(memberToTest.Sin(i), Math.Sin(i));
        }

        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

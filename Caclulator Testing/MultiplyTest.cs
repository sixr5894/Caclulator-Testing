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
    public class MultiplyTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void MultiplyTesting()
        {
            for (double i = -100; i < 100; i += 0.01)
                for (double c = -100; c < 100; c += 0.01)
                    Assert.AreEqual(memberToTest.Multiply(i, c), i * c);
        }

        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

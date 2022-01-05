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
    public class DivideTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void DivideDouble()
        {
            for (double i = -100; i < 100; i += 0.01)
            {
                for (double c = -100; c < 100; c += 0.01)
                    if (c != 0)
                        Assert.AreEqual<double>(memberToTest.Divide(i, c), i / c);
            }
        }

        [TestCleanup]
        public override void Clean() => base.Initialize();
    }
}

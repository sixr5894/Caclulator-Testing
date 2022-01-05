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
     public class PowerTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void PowerTestingToString() => Power(ToString: true);

        [TestMethod]
        public void PowerTestingDouble() => Power();
        void Power(bool ToString = false)
        {
            for (double i = 1; i < 5; i += 0.01)
                for (double c = 1; c < 10; c += 0.01)
                {
                    double expected = Math.Pow(c, i);
                    double actual = ToString ? memberToTest.Pow(c.ToString(), i.ToString()) : memberToTest.Pow(c, i);
                    Assert.AreEqual(expected, actual);
                }
                    
        }
        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

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
    public class SubtractionTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();

        [TestMethod]
        public void SubtractionTestingTosring() => Subtraction(ToString: true);

        [TestMethod]
        public void SubtractionTestingDouble() => Subtraction();

        void Subtraction(bool ToString = false)
        {
            for(double i=-100; i < 100; i+=0.01)
                for(double c = -100; c < 100; c += 0.01)
                {
                    double expected = i-c;
                    double actual = ToString ? memberToTest.Sub(i.ToString(), c.ToString()) : memberToTest.Sub(i,c);
                    Assert.AreEqual(expected, actual);
                }
        }
        [TestCleanup]
        public override void Clean() => base.Clean();
    }
}

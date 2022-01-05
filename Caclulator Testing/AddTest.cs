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
    public class AddTest : BaseTestEntity<Calculator>
    {
        [TestInitialize]
        public override void Initialize() => base.Initialize();
        [TestMethod]
        public void AddDoubles() => Adding();

        [TestMethod]
        public void AddStrings() => Adding(ToString: true);

        [TestCleanup]
        public override void Clean() => base.Clean(); 

        void Adding(bool ToString = false)
        {
            for (double i = -1000; i < 1000; i += 0.1)
            {
                for (double k = -1000; k < 1000; k += 0.1)
                {
                    double expected = i+k;
                    double actual = ToString ? memberToTest.Add(i.ToString(), k.ToString()) : memberToTest.Add(i,k);
                    Assert.AreEqual<double>(actual, expected);
                }
            }
        }
    }
}

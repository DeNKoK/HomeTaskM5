using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class AbsTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(-5, 5)]
        [DataRow(5, 5)]
        [DataRow(0, 0)]
        [DataRow(-5.87, 5.87)]
        public void Abs_PossitiveScenario(double input, double expected)
        {
            Assert.AreEqual(expected, _calc.Abs(input));
        }

        [DataTestMethod]
        [DataRow(-1000, -1000)]
        [DataRow(1000, -1000)]
        public void Abs_NegativeScenario(object input, double expected)
        {
            Assert.IsFalse(_calc.Abs(input) == expected);
        }

        [DataTestMethod]
        [DataRow("-999", 999)]
        [DataRow("999.99", 999.99)]
        public void Abs_StringInput(string input, double expected)
        {
            Assert.AreEqual(expected, _calc.Abs(input));
        }
    }
}
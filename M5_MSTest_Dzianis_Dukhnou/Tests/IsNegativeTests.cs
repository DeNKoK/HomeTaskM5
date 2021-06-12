using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class IsNegativeTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-0.00001)]
        [DataRow(-999)]
        [DataRow("-10000000000000")]
        public void IsNegative_True(object input)
        {
            Assert.IsTrue(_calc.isNegative(input));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(0.00001)]
        [DataRow(999)]
        [DataRow("10000000000000")]
        public void IsNegative_False(object input)
        {
            Assert.IsFalse(_calc.isNegative(input));
        }
    }
}
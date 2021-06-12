using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class IsPositiveTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(10)]
        [DataRow(0.00001)]
        [DataRow(999)]
        [DataRow(10000000000000)]
        public void IsPositive_True(object input)
        {
            Assert.IsTrue(_calc.isPositive(input));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-0.00001)]
        [DataRow(-999)]
        [DataRow("-10000000000000")]
        public void IsPositive_False(object input)
        {
            Assert.IsFalse(_calc.isPositive(input));
        }
    }
}
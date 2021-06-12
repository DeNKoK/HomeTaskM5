using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class SubTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(1, 100, -99)]
        [DataRow(0, 0.0001, -0.0001)]
        [DataRow(100, 100, 0)]
        [DataRow(-1, -5, 4)]
        public void Subtraction(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Sub(input1, input2));
        }
    }
}
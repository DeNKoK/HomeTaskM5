using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class AddTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(10, 5, 15)]
        [DataRow(0, -0.0001, -0.0001)]
        [DataRow(-1, -5, -6)]
        [DataRow(1.99, 0.001, 1.991)]
        public void Addition_DoubleInput(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Add(input1, input2));
        }
    }
}
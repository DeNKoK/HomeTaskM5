using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class MultiplyTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(3, 3, 9)]
        [DataRow(3, 1, 3)]
        [DataRow(0, 5, 0)]
        [DataRow(-3, 5, -15)]
        [DataRow(2.55, 3.33, 8.4915)]
        public void Multiplication(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Multiply(input1, input2));
        }
    }
}
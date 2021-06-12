using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class SqrtTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(9, 3)]
        [DataRow(6.754801, 2.599)]
        [DataRow(0, 0)]
        public void Sqrt(double input, double expected)
        {
            Assert.AreEqual(expected, _calc.Sqrt(input));
        }
    }
}
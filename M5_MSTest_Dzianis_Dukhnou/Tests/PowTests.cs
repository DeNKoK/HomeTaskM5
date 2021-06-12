using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class PowTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(3, 2, 9)]
        [DataRow(3, 1, 3)]
        [DataRow(0, 5, 0)]
        [DataRow(-2, 2, 4)]
        [DataRow(-3, 3, -27)]
        [DataRow(2.55, 3, 16.581375)]
        [DataRow("32", "8", "1048576")]
        public void Pow(object input1, object input2, object expected)
        {
            Assert.AreEqual(expected, _calc.Pow(input1, input2));
        }
    }
}
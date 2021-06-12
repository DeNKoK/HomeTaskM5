using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class CosTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(30, 0.15425144988758405)]
        [DataRow(3.14159265358979323846, -1)]
        public void Cosine(double input, double expected)
        {
            Assert.AreEqual(expected, _calc.Cos(input));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class SinTests : TestInitialize
    {
        [DataTestMethod]
        [DataRow(30, -0.988031624092861789)]
        [DataRow(3.14159265358979323846, 0)] //Bug7
        public void Sinus(object input, object expected)
        {
            Assert.AreEqual(expected, _calc.Sin(input));
        }
    }
}
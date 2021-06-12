using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SubTests : TestInitialize
    {
        [TestCase(10, 5, 5)]
        [TestCase(1, 100, -99)]
        [TestCase(0, 0.0001, -0.0001)]
        [TestCase(100, 100, 0)]
        [TestCase(-1, -5, 4)]
        [TestCase("1.99", "0.001", 1.989)]
        [TestCase("201", "100", "101")] //Bug8 : Type of Output
        public void Subtraction(object input1, object input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Sub(input1, input2));
        }
    }
}
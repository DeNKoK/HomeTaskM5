using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class PowTests : TestInitialize
    {
        [TestCase(3, 2, 9)]
        [TestCase(3, 1, 3)]
        [TestCase(0, 5, 0)]
        [TestCase(-2, 2, 4)]
        [TestCase(-3, 3, -27)]
        [TestCase(2.55, 3, 16.581375)]
        [TestCase("32", "8", "1048576")]
        public void Pow(object input1, object input2, object expected)
        {
            Assert.AreEqual(expected, _calc.Pow(input1, input2));
        }
    }
}
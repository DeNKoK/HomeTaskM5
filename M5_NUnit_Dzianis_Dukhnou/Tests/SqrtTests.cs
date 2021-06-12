using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SqrtTests : TestInitialize
    {
        [TestCase(9, 3)]
        [TestCase("25", 5)]
        [TestCase(25, "5")]
        [TestCase("81", "9")]
        [TestCase(0, 0)]
        public void Sqrt(object input, double expected)
        {
            Assert.AreEqual(expected, _calc.Sqrt(input));
        }
    }
}
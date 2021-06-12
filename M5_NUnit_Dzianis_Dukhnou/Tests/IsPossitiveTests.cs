using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class IsPositiveTests : TestInitialize
    {
        [TestCase(10)]
        [TestCase(0.00001)]
        [TestCase(999)]
        [TestCase(10000000000000)]
        public void IsPositive_True(object input)
        {
            Assert.IsTrue(_calc.isPositive(input));
        }

        [TestCase(0)]
        [TestCase(-0.00001)]
        [TestCase(-999)]
        [TestCase("-10000000000000")]
        public void IsPositive_False(object input)
        {
            Assert.IsFalse(_calc.isPositive(input));
        }
    }
}
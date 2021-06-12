using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class IsNegativeTests : TestInitialize
    {
        [TestCase(-1)]
        [TestCase(-0.00001)]
        [TestCase(-999)]
        [TestCase("-10000000000000")]
        public void IsNegative_True(object input)
        {
            Assert.IsTrue(_calc.isNegative(input));
        }

        [TestCase(0)]
        [TestCase(0.00001)]
        [TestCase(999)]
        [TestCase("10000000000000")]
        public void IsNegative_False(object input)
        {
            Assert.IsFalse(_calc.isNegative(input));
        }
    }
}
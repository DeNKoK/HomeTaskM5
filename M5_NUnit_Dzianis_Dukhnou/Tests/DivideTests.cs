using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class DevideTests : TestInitialize
    {
        [TestCase(3, 3, 1)]
        [TestCase(3, 1, 3)]
        [TestCase(0, 5, 0)]
        [TestCase(-654653, -5, 130930.6)]
        [TestCase(-654653, 5, -130930.6)]
        [TestCase("32", "8", "4")]
        [TestCase("32", "3", 10.666666666666666)]
        public void Division(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Divide(input1, input2));
        }

        [Test, Sequential]
        public void DivisionBy2([Values(10, 25, 40)] double input1, [Values(5, 12.5, 20)] double expected)
        {
            Assert.AreEqual(expected, _calc.Divide(input1, 2));
        }
    }
}

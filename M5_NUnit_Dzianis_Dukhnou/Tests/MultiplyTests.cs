using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MultiplyTests : TestInitialize
    {
        [TestCase(3, 3, 9)]
        [TestCase(3, 1, 3)]
        [TestCase(0, 5, 0)]
        [TestCase(-3, 5, -15)]
        [TestCase(2.55, 3.33, 8.4915)]
        [TestCase("32", "8", "256")]
        [TestCase("32.33", "8", 258.64)]
        public void Multiplication(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Multiply(input1, input2));
        }
    }
}
using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AddTests : TestInitialize
    {
        [TestCase(10, 5, 15)]
        [TestCase(0, -0.0001, -0.0001)]
        [TestCase(-1, -5, -6)]
        [TestCase(1.99, 0.001, 1.991)] //Bug3
        [TestCase("1.99", "0.001", 1.991)] //Bug3
        [TestCase("201", "100", "301")]
        public void Addition_DoubleInput(double input1, double input2, double expected)
        {
            Assert.AreEqual(expected, _calc.Add(input1, input2));
        }

        [TestCase(10, 5, 15)] //Bug4
        public void Addition_ObjectInput(object input1, object input2, object expected)
        {
            Assert.AreEqual(expected, _calc.Add(input1, input2));
        }
    }
}
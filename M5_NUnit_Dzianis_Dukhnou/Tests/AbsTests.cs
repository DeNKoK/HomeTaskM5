using NUnit.Framework;

[assembly: LevelOfParallelism(6)]
namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AbsTests : TestInitialize
    {
        [TestCase(-5, 5)]
        [TestCase(5, 5)]
        [TestCase(0, 0)]
        [TestCase(-5.87, 5.87)]
        public void Abs_PossitiveScenario(object input, object expected)
        {
            Assert.AreEqual(expected, _calc.Abs(input), "Failed because of the following:");
        }

        [TestCase(-1000, -1000)]
        [TestCase(1000, -1000)]
        public void Abs_NegativeScenario(object input, double expected)
        {
            Assert.IsFalse(_calc.Abs(input) == expected, "Failed because of the following:");
        }

        [TestCase("-999", 999)]
        [TestCase("-999.99", "999.99")]
        public void Abs_StringInput(string input, object expected)
        {
            Assert.AreEqual(expected, _calc.Abs(input), "Failed because of the following:");
        }
    }
}
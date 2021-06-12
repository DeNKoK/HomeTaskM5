using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SinTests : TestInitialize
    {
        [TestCase(30, -0.988031624092861789)]
        [TestCase(3.14159265358979323846, 0)]
        public void Sinus(object input, object expected)
        {
            Assert.AreEqual(expected, _calc.Sin(input));
        }
    }
}
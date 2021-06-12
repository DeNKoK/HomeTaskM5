using NUnit.Framework;

namespace NUnit_Calc.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class CosTests : TestInitialize
    {
        [TestCase(30, 0.15425144988758405)]
        [TestCase(3.14159265358979323846, -1)]
        public void Cosine(object input, object expected)
        {
            Assert.AreEqual(expected, _calc.Cos(input));
        }
    }
}
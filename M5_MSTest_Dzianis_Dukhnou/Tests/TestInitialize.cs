using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTest_Calc.Tests
{
    public class TestInitialize
    {
        public Calculator _calc;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void BaseInt()
        {
            _calc = new Calculator();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _calc = null;
        }
    }
}

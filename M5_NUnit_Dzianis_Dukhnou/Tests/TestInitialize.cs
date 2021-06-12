using NUnit.Framework;
using CSharpCalculator;
//[SetUpFixture]
//[TestFixtureSetUp]
//[assembly: LevelOfParallelism(4)]
namespace NUnit_Calc.Tests
{
    public class TestInitialize
    {
        public Calculator _calc;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _calc = new Calculator();
        }

        [OneTimeTearDown]
        public void OnteTimeTearDown()
        {
            _calc = null;
        }
    }
}
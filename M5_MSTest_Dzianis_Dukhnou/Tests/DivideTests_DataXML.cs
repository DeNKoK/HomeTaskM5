using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTest_Calc.Tests
{
    [TestClass]
    public class DivideTests : TestInitialize
    {
        const string connectionStringToFile = "C:\\Users\\Dzianis_Dukhnou\\source\\repos\\M5_Dzianis_Dukhnou\\M5_MSTest_Dzianis_Dukhnou\\TestData\\TestData.xml";
        const string dataProvider = "Microsoft.VisualStudio.TestTools.DataSource.XML";

        [TestMethod]
        [DataSource(dataProvider, connectionStringToFile, "Division", DataAccessMethod.Sequential)]
        public void Division_DataDrivenXML()
        {
            double rowInput1 = Convert.ToDouble(TestContext.DataRow["Input1"]);
            double rowInput2 = Convert.ToDouble(TestContext.DataRow["Input2"]);
            double rowOutput = Convert.ToDouble(TestContext.DataRow["Output"]);
            Assert.AreEqual(rowOutput, _calc.Divide(rowInput1, rowInput2));
        }
    }
}
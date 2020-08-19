using System;
using ExcelSearchBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EDRExcelWrapperTest
    {
        [TestMethod]
        public void RightColumn3()
        {
            // ssl_marius
            // 789Marius987.-
            var excelWrapper = new EDRExcelWrapper(@"C:\Users\mariu\OneDrive\Documents\Kennliste2.xlsx");
            string[] obj = excelWrapper.GetRow(2);
            Assert.AreEqual(obj[2].Trim(), "LP FY 20");
            Assert.AreEqual(obj[7].Trim(), "Pump ID");
        }
        [TestMethod]
        public void SearchTest()
        {
            var excelWrapper = new EDRExcelWrapper(@"C:\Users\mariu\OneDrive\Documents\Kennliste2.xlsx");
            var res = excelWrapper.SearchRow("D951-5001");
            Assert.AreEqual(1, res.Count);
            string[] obj = res[0];
            Assert.AreEqual(obj[0].Trim(), "D951-5001");
            Assert.AreEqual(obj[1].Trim(), "HPR18B1RKP019SM28F1Y00RKP019SM28F1Y00");
        }
        [TestMethod]
        public void SearchCaseInsensitive()
        {
            var excelWrapper = new EDRExcelWrapper(@"C:\Users\mariu\OneDrive\Documents\Kennliste2.xlsx");
            var res = excelWrapper.SearchRow("d951-5001");
            Assert.AreEqual(1, res.Count);
            string[] obj = res[0];
            Assert.AreEqual(obj[0].Trim(), "D951-5001");
            Assert.AreEqual(obj[1].Trim(), "HPR18B1RKP019SM28F1Y00RKP019SM28F1Y00");
        }
    }
}

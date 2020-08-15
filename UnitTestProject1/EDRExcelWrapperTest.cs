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
            string[] obj = excelWrapper.GetCol(2);
            Assert.AreEqual(obj[2].Trim(), "LP FY 20");
            Assert.AreEqual(obj[7].Trim(), "Pump ID");
        }
    }
}

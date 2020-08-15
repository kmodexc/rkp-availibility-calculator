using System;
using ExcelSearchBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateDataSheetTest
    {
        [TestMethod]
        public void CreateDataSheet_NoException()
        {
            DataSheetCreator dataSheetCreator = new DataSheetCreator();
            string[] obj = new string[100];
            for (int cnt = 0; cnt < obj.Length; cnt++) obj[cnt] = "testStr_" + cnt;
            dataSheetCreator.CreateDataSheet(obj);
        }
        
    }
}

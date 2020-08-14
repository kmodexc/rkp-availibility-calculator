using System;
using System.Collections.Generic;

namespace ExcelSearchBox
{
    public class EDRExcelWrapper : ExcelWrapper
    {
        private string filename = @"C:\Users\mariu\OneDrive\Documents\Kennliste.xlsx";
        public EDRExcelWrapper()
        {
        }
        public EDRExcelWrapper(string str)
        {
            filename = str;
        }

        public string GetFilename()
        {
            return filename;
        }

        public string[] GetCol(int c)
        {
            throw new NotImplementedException();
        }

        public List<string[]> SearchRow(string searchStr)
        {
            throw new NotImplementedException();
        }

        public void SetFilename(string str)
        {
            filename = str;
        }
    }
}

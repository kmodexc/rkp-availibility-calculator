using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ExcelSearchBox
{
    public class EDRExcelWrapper : ExcelWrapper
    {
        private string filename = @"C:\Users\mariu\OneDrive\Documents\Kennliste2.xlsx";
        private int colCount;
        private int rowCount;

        public EDRExcelWrapper()
        {
            CalcTableSize();
        }
        public EDRExcelWrapper(string str)
        {
            filename = str;
            CalcTableSize();
        }

        public string GetFilename()
        {
            return filename;
        }

        public void CalcTableSize()
        {
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var table = result.Tables[0];
                    rowCount = table.Rows.Count;
                    colCount = table.Columns.Count;
                }
            }
        }

        public string[] GetCol(int c)
        {
            string[] ret;
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var table = result.Tables[0];
                    var row = table.Rows[c];
                    var colCount = table.Columns.Count;
                    ret = new string[colCount];
                    for (int cnt = 0; cnt < colCount; cnt++)
                    {
                        ret[cnt] = (row[cnt]).ToString();
                    }
                }
            }
            return ret;
        }

        private string[] GetCol(DataRow row)
        {
            string[] ret = new string[colCount];
            for (int cnt = 0; cnt < colCount; cnt++)
            {
                ret[cnt] = (row[cnt]).ToString();
            }
            return ret;
        }

        public List<string[]> SearchRow(string searchStr)
        {
            List<string[]> ret = new List<string[]>();
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var table = result.Tables[0];
                    foreach(DataRow row in result.Tables[0].Rows)
                    {
                        string val = (row[0]).ToString();
                        if (val.Contains(searchStr))
                        {
                            ret.Add(GetCol(row));
                        }
                    }      
                }
            }
            return ret;
        }

        public void SetFilename(string str)
        {
            filename = str;
        }
    }
}

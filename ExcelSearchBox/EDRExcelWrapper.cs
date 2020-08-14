using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ExcelSearchBox
{
    public class EDRExcelWrapper : ExcelWrapper
    {
        private string filename = @"C:\Users\mariu\OneDrive\Documents\Kennliste.xlsx";
        private int rowLen = 51;

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
            string[] ret = new string[rowLen];
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    for (int cnt = 0; cnt < rowLen; cnt++)
                    {
                        ret[cnt] = (result.Tables[0].Rows[c][cnt]).ToString();
                    }
                }
            }
            return ret;
        }

        private string[] GetCol(DataRow row)
        {
            string[] ret = new string[rowLen];
            for (int cnt = 0; cnt < rowLen; cnt++)
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

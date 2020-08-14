using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ExcelSearchBox
{
    public class OfficeExcelWrapper : ExcelWrapper
    {
        private string filename = @"C:\Users\mariu\OneDrive\Documents\Kennliste.xlsx";
        private bool isFileInUse = false;
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Workbook xlWorkbook;
        private dynamic xlWorksheet;
        private Range xlRange;

        public OfficeExcelWrapper()
        {
            OpenFile();
        }

        public OfficeExcelWrapper(string sourceFile)
        {
            this.filename = sourceFile;
        }

        ~OfficeExcelWrapper()
        {
            CloseFile();
        }
        public string GetFilename()
        {
            return filename;
        }
        public void SetFilename(string str)
        {
            CloseFile();
            filename = str;
            OpenFile();
        }
        private Range OpenFile()
        {
            if (isFileInUse)
            {
                throw new Exception("File is in use.");
            }
            isFileInUse = true;

            //Create COM Objects. Create a COM object for everything that is referenced
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
            }
            catch (Exception)
            {
                isFileInUse = false;
                throw;
            }
            try
            {
                xlWorkbook = xlApp.Workbooks.Open(filename);
            }
            catch (Exception)
            {
                isFileInUse = false;
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                throw;
            }
            try
            {
                xlWorksheet = xlWorkbook.Sheets[1];
            }
            catch (Exception)
            {
                isFileInUse = false;
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                throw;
            }
            try
            {
                xlRange = xlWorksheet.UsedRange;
            }
            catch (Exception)
            {
                isFileInUse = false;
                Marshal.ReleaseComObject(xlWorksheet);
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                throw;
            }
            return xlRange;
        }
        public void PrintFile()
        {
            if (!isFileInUse) throw new Exception("File not open");
            for (int i = 1; i <= xlRange.Rows.Count; i++)
            {
                for (int j = 1; j <= xlRange.Columns.Count; j++)
                {
                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");

                }
                Console.WriteLine();
            }
        }
        public List<string[]> SearchRow(string searchStr)
        {
            if (!isFileInUse) throw new Exception("File not open");
            List<string[]> ret = new List<string[]>();
            int rows = xlRange.Rows.Count;
            Range cells = xlWorksheet.Columns["A:A"].Cells;

            foreach (var cell in cells)
            {
                Console.WriteLine(cell.ToString());
            }

            for (int i = 1; i <= rows; i++)
            {
                //write the value to the console
                var obj_cell = cells[i, 1];
                if (obj_cell != null)
                {
                    var val_cell = obj_cell.Value2;
                    if (val_cell != null)
                    {
                        string content = val_cell.ToString();
                        if (content.Contains(searchStr))
                        {
                            ret.Add(ColToStr(xlRange, i));
                        }
                    }
                }
            }
            return ret;
        }
        public string[] GetFirstCol()
        {
            if (!isFileInUse) throw new Exception("File not open");
            return ColToStr(xlRange, 1);
        }
        public string[] GetSecCol()
        {
            if (!isFileInUse) throw new Exception("File not open");
            return ColToStr(xlRange, 2);
        }
        public string[] GetThirdCol()
        {
            if (!isFileInUse) throw new Exception("File not open");
            return ColToStr(xlRange, 3);
        }
        public void PrintCol(string[] str)
        {
            for (int j = 0; j < str.Length; j++)
            {
                Console.Write(str[j] + "\t");
            }
            Console.WriteLine();
        }
        public string[] ColToStr(Range range, int row)
        {
            if (!isFileInUse) throw new Exception("File not open");
            string[] ret = new string[range.Columns.Count];
            for (int j = 1; j <= range.Columns.Count; j++)
            {
                //write the value to the console
                if (xlRange.Cells[row, j] != null && xlRange.Cells[row, j].Value2 != null)
                    ret[j - 1] = (xlRange.Cells[row, j].Value2.ToString());
            }
            return ret;
        }
        private void CloseFile()
        {
            if (!isFileInUse) return;

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            isFileInUse = false;
        }
    }
}

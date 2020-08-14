using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSearchBox
{
    interface ExcelWrapper
    {
        string GetFilename();
        void SetFilename(string str);
        void PrintFile();
        List<string[]> SearchRow(string searchStr);
        string[] GetFirstCol();
        string[] GetSecCol();
        string[] GetThirdCol();
        void PrintCol(string[] str);
        string[] ColToStr(Range range, int row);
        
    }
}

using System.Collections.Generic;
namespace ExcelSearchBox
{
    interface ExcelWrapper
    {
        string GetFilename();
        void SetFilename(string str);
        List<string[]> SearchRow(string searchStr);
        string[] GetRow(int c);
        int GetColumnCount();
        int GetRowCount();
    }
}

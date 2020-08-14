using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSearchBox
{
    public class DataSheetCreator
    {
        private string filename = @"C:\Users\mariu\OneDrive\Documents\Kennliste2.xlsx";
        Dictionary<string, string>[] descDict;
        string[] propertys;
        public DataSheetCreator()
        {
            descDict = new Dictionary<string, string>[13];
            for (int cnt = 0; cnt < descDict.Length; cnt++) descDict[cnt] = new Dictionary<string, string>();
            propertys = new string[13];
            CreateDictionary();
        }
        public void CreateDictionary()
        {
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var table = result.Tables[6];
                    if (!table.Rows[0][0].ToString().Contains("Pos"))
                    {
                        throw new Exception("wrong table");
                    }
                    int key = -1;
                    foreach (DataRow row in table.Rows)
                    {
                        string val = (row[0]).ToString();
                        int num = -1;
                        if (int.TryParse(val, out num))
                        {
                            key = num;
                            propertys[key] = row[2].ToString();
                        }
                        else if (val.StartsWith("-"))
                        {
                            key = -1;
                        }
                        else if (key > 0)
                        {
                            if (!string.IsNullOrWhiteSpace(row[1].ToString()))
                            {
                                // todo for 12

                                if (descDict[key].ContainsKey(row[1].ToString()))
                                {
                                    Console.WriteLine(row[1].ToString());
                                    Console.WriteLine(row[2].ToString());
                                    Console.WriteLine(descDict[key][row[1].ToString()]);
                                    Console.WriteLine();
                                }

                                // todo for 12


                                descDict[key].Add(row[1].ToString(), row[2].ToString());
                            }                            
                        }

                        // last parameter can not be exactly parsed
                        if (key >= 12) break;

                    }
                }
            }
        }
        public void CreateDataSheet(string[] obj)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Pumpennummer:;" + obj[0]);
            csv.AppendLine("Pumpenschlüssel:;" + obj[1]);
            for (int cnt = 0; (cnt+1) < descDict.Length && (cnt+7) < obj.Length; cnt++)
            {
                int objIndex = cnt + 7;
                int dictIndex = cnt + 1;
                string keyValue = (descDict[dictIndex].ContainsKey(obj[objIndex]) ? descDict[dictIndex][obj[objIndex]] : "");

                keyValue = keyValue.Replace('\n', '\t');
                keyValue = keyValue.Replace('\r', '\t');
                keyValue = keyValue.Replace(';', ' ');

                // todo

                if (string.IsNullOrWhiteSpace(keyValue) && !string.IsNullOrWhiteSpace(obj[objIndex]))
                {
                    Console.WriteLine(keyValue + "\t" + obj[objIndex]);
                }


                csv.AppendLine(propertys[dictIndex] + ';' + obj[objIndex] + ';' + keyValue);
            }
            File.WriteAllText(obj[0] + ".csv", csv.ToString(),Encoding.UTF8);
        }
    }
}

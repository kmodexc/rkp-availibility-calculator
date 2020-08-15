using ExcelSearchBox.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExcelSearchBox
{
    public partial class SearchBox : Form
    {
        private ExcelWrapper excelWrapper;
        private string[] nameCol;
        private List<string[]> itemList;

        public SearchBox()
        {
            InitializeComponent();
        }

        private void LoadExcelWrapper()
        {
            try
            {
                if (File.Exists(Settings.Default.sourceFile))
                    excelWrapper = new EDRExcelWrapper(Settings.Default.sourceFile);
                else
                {
#if DEBUG
                    excelWrapper = new EDRExcelWrapper();
#endif
                    MessageBox.Show("Die Quelldatei ist ungültig (\"" + Settings.Default.sourceFile + "\"). Bitte andere Datei einstellen.");
                }
                if (excelWrapper != null)
                {
                    textBoxSourceFile.Text = excelWrapper.GetFilename();
                    nameCol = excelWrapper.GetCol(2);
                    if (nameCol == null)
                    {
                        MessageBox.Show("Die Quelldatei ist ungültig. Bitte andere Datei einstellen.");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (excelWrapper == null) return;
            try
            {
                listSearchResults.Items.Clear();

                Cursor.Current = Cursors.WaitCursor;

                itemList = excelWrapper.SearchRow(textBoxSearchString.Text);

                Cursor.Current = Cursors.Default;

                if (itemList == null)
                {
                    MessageBox.Show("Nichts gefunden");
                    return;
                }
                for (int cnt = 0; cnt < itemList.Count; cnt++)
                {
                    listSearchResults.Items.Add(itemList[cnt][0]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void textBoxSearchString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (excelWrapper == null) return;
            if (e.KeyChar == (char)13)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void listSearchResults_DoubleClick(object sender, EventArgs e)
        {
            if (excelWrapper == null) return;
            try
            {
                if (listSearchResults.SelectedIndex < 0) return;
                tabControl.SelectedTab = tabDetails;
                labelDetailName.Text = "";
                listDetails.Items.Clear();
                string[] obj = itemList[listSearchResults.SelectedIndex];
                labelDetailName.Text = "Pumpennummer: " + obj[0];
                labelTypeCode.Text = "Typenschlüssel: " + obj[1];
                listDetails.Columns[0].Width = 300;
                listDetails.Columns[1].Width = 200;
                for (int cnt = 1; cnt < obj.Length; cnt++)
                {
                    string[] str = new string[2];
                    str[0] = nameCol[cnt];
                    str[1] = obj[cnt];
                    listDetails.Items.Add(new ListViewItem(str));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (excelWrapper == null || excelWrapper.GetFilename() != textBoxSourceFile.Text)
            {
                Settings.Default.sourceFile = textBoxSourceFile.Text;
                Settings.Default.Save();
                Settings.Default.Upgrade();
                LoadExcelWrapper();
            }
        }

        private void SearchBox_Shown(object sender, EventArgs e)
        {
            LoadExcelWrapper();
        }

        private void buttonDatasheet_Click(object sender, EventArgs e)
        {
            if (excelWrapper == null) return;
            try
            {
                DataSheetCreator dataSheetCreator = new DataSheetCreator();
                dataSheetCreator.SetFilename(excelWrapper.GetFilename());
                string content = dataSheetCreator.CreateDataSheet(itemList[listSearchResults.SelectedIndex]);
                this.saveFileDialog1.DefaultExt = ".csv";
                this.saveFileDialog1.FileName = itemList[listSearchResults.SelectedIndex][1];
                this.saveFileDialog1.AddExtension = true;
                this.saveFileDialog1.CheckPathExists = true;
                this.saveFileDialog1.Filter = "CSV Dateien | *.csv";
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(this.saveFileDialog1.FileName, content);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}

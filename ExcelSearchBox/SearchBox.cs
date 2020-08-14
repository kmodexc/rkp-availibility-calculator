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
                if (Uri.IsWellFormedUriString(Settings.Default.sourceFile, UriKind.Absolute))
                {
                    excelWrapper = new EDRExcelWrapper(Settings.Default.sourceFile);
                }
                else
                {
                    excelWrapper = new EDRExcelWrapper();
                    MessageBox.Show("Die Quelldatei ist ungültig (\"" + Settings.Default.sourceFile + "\"). Bitte andere Datei einstellen.");
                }
                textBoxSourceFile.Text = excelWrapper.GetFilename();
                nameCol = excelWrapper.GetCol(2);
                if (nameCol == null)
                {
                    MessageBox.Show("Die Quelldatei ist ungültig. Bitte andere Datei einstellen.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
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
                for(int cnt=0;cnt<itemList.Count;cnt++)
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
            if (e.KeyChar == (char)13)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void listSearchResults_DoubleClick(object sender, EventArgs e)
        {
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
            if (excelWrapper.GetFilename() != textBoxSourceFile.Text)
            {
                Settings.Default.sourceFile = textBoxSourceFile.Text;
                Settings.Default.Save();
                LoadExcelWrapper();
            }
        }

        private void SearchBox_Shown(object sender, EventArgs e)
        {
            LoadExcelWrapper();
        }

        private void buttonDatasheet_Click(object sender, EventArgs e)
        {
            try
            {
                DataSheetCreator dataSheetCreator = new DataSheetCreator();
                dataSheetCreator.CreateDataSheet(itemList[listSearchResults.SelectedIndex]);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }            
        }
    }
}

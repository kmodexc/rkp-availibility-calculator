using ExcelSearchBox.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExcelSearchBox
{
    public partial class SearchBox : Form
    {
        private ExcelWrapper excelWrapper;
        private string[] nameCol;

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
                    excelWrapper = new OfficeExcelWrapper(Settings.Default.sourceFile);
                }
                else
                {
                    excelWrapper = new OfficeExcelWrapper();
                    MessageBox.Show("Die Quelldatei ist ungültig (\"" + Settings.Default.sourceFile + "\"). Bitte andere Datei einstellen.");
                }
                textBoxSourceFile.Text = excelWrapper.GetFilename();
                nameCol = excelWrapper.GetCol(3);
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

                var res = excelWrapper.SearchRow(textBoxSearchString.Text);

                Cursor.Current = Cursors.Default;

                if (res == null)
                {
                    MessageBox.Show("Nichts gefunden");
                    return;
                }
                foreach (string[] arr in res)
                {
                    listSearchResults.Items.Add(arr[0]);
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
                Cursor.Current = Cursors.WaitCursor;
                string[] obj = excelWrapper.SearchRow(listSearchResults.SelectedItem.ToString())[0];
                Cursor.Current = Cursors.Default;
                labelDetailName.Text = "Pumpennummer: " + obj[0];
                for (int cnt = 2; cnt < obj.Length; cnt++)
                {
                    listDetails.Items.Add($"{nameCol[cnt],-100}\t{obj[cnt],-30}");
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
    }
}

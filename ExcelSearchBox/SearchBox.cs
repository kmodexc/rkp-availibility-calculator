using ExcelSearchBox.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSearchBox
{
    public partial class SearchBox : Form
    {
        private ExcelWrapper excelWrapper;
        private string[] nameCol;
        private List<string[]> itemList;
        private TextBox[,] componentsMatrix;
        MaterialMatrix materialMat;
        int materialMatLastPosEntrys;

        public SearchBox()
        {
            InitializeComponent();
            CreateComponentsTab();
            materialMatLastPosEntrys = 0;
            // if component are saved it may have more sense
            //(new Thread(LoadStatistics)).Start();
        }

        private string LoadStatistics()
        {
            if (materialMat == null || !materialMat.IsNotNegativ() || materialMat.CountNonNegativeEntrys() < 3)
                return Statistics.STR_LOADING_STATISTIC_WAIT;
            Statistics stat = Statistics.CalcStatistics(excelWrapper, materialMat);
            if (stat == null) return "could not calculate stat";
            return stat?.ToString();
        }

        private void LoadExcelWrapper()
        {
            try
            {
                if (File.Exists(Settings.Default.sourceFile))
                    excelWrapper = new EDRExcelWrapper(Settings.Default.sourceFile);
                else
                {
                    MessageBox.Show("Die Quelldatei ist ungültig (\"" + Settings.Default.sourceFile + "\"). Bitte andere Datei einstellen.");
                }
                if (excelWrapper != null)
                {
                    textBoxSourceFile.Text = excelWrapper.GetFilename();
                    nameCol = excelWrapper.GetRow(2);
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

        private void CreateComponentsTab()
        {
            materialMat = new MaterialMatrix();
            componentsMatrix = new TextBox[MaterialMatrix.SIZE_X, MaterialMatrix.SIZE_Y];

            Label[] labelX = new Label[3 * MaterialMatrix.SIZE_X];
            for (int cnt = 0; cnt < labelX.Length; cnt++) labelX[cnt] = new Label();
            Label[] labelY = new Label[MaterialMatrix.SIZE_Y];
            for (int cnt = 0; cnt < labelY.Length; cnt++) labelY[cnt] = new Label();

            for (int x = 0; x < MaterialMatrix.SIZE_X; x++)
            {
                for (int y = 0; y < MaterialMatrix.SIZE_Y; y++)
                {
                    componentsMatrix[x, y] = new TextBox();
                    int px = 0, py = 0;
                    if (y < 7)
                    {
                        px = 90 + 30 * x;
                        py = 60 + 30 * y;
                    }
                    else if (y >= 7 && y < 21)
                    {
                        px = (MaterialMatrix.SIZE_X + 6) * 30 + 30 * x;
                        py = (-6 * 30) + 30 * y;
                    }
                    else
                    {
                        px = 2 * (MaterialMatrix.SIZE_X + 5) * 30 + 30 * x;
                        py = (-20 * 30) + 30 * y;
                    }
                    if (x == 0)
                    {
                        labelY[y].Location = new System.Drawing.Point(px - 65, py);
                        labelY[y].AutoSize = true;
                        labelY[y].Text = "" + y;
                        groupComponents.Controls.Add(labelY[y]);
                    }
                    if (y == 0)
                    {
                        labelX[x].Location = new System.Drawing.Point(px, py - 20);
                        labelX[x].AutoSize = true;
                        labelX[x].Text = "" + x;
                        groupComponents.Controls.Add(labelX[x]);
                    }
                    if (y == 7)
                    {
                        labelX[x + 7].Location = new System.Drawing.Point(px, py - 20);
                        labelX[x + 7].AutoSize = true;
                        labelX[x + 7].Text = "" + x;
                        groupComponents.Controls.Add(labelX[x + 7]);
                    }
                    if (y == 21)
                    {
                        labelX[x + 14].Location = new System.Drawing.Point(px, py - 20);
                        labelX[x + 14].AutoSize = true;
                        labelX[x + 14].Text = "" + x;
                        groupComponents.Controls.Add(labelX[x + 14]);
                    }
                    componentsMatrix[x, y].Location = new System.Drawing.Point(px, py);
                    componentsMatrix[x, y].Name = "textBox" + x + "_" + y;
                    componentsMatrix[x, y].TabIndex = x + y * MaterialMatrix.SIZE_X;
                    componentsMatrix[x, y].Text = "";
                    componentsMatrix[x, y].Size = new System.Drawing.Size(30, 31);
                    componentsMatrix[x, y].TextChanged += components_textchanged;
                    componentsMatrix[x, y].Enabled = !materialMat.IsInactive(x, y);
                    groupComponents.Controls.Add(componentsMatrix[x, y]);
                }
            }
            for (int cnt = 0; cnt < labelX.Length; cnt++) labelX[cnt].Text = MaterialMatrix.LabelMatX[int.Parse(labelX[cnt].Text)];
            for (int cnt = 0; cnt < labelY.Length; cnt++) labelY[cnt].Text = MaterialMatrix.LabelMatY[int.Parse(labelY[cnt].Text)];
        }

        private void components_textchanged(object sender, EventArgs e)
        {
            TextBox sender_textbox = sender as TextBox;
            if (sender_textbox != null)
            {
                int sender_x = -1, sender_y = -1;
                for (int x = 0; x < MaterialMatrix.SIZE_X; x++)
                {
                    for (int y = 0; y < MaterialMatrix.SIZE_Y; y++)
                    {
                        if (sender_textbox == componentsMatrix[x, y])
                        {
                            sender_x = x;
                            sender_y = y;
                        }
                    }
                }
                int val = MaterialMatrix.INACTIVE_ENTRY;
                if (int.TryParse(sender_textbox.Text, out val))
                {
                    materialMat[sender_x, sender_y] = val;
                }
                if (sender_textbox.Text == "")
                {
                    materialMat[sender_x, sender_y] = 0;
                }
            }
            for (int x = 0; x < MaterialMatrix.SIZE_X; x++)
            {
                for (int y = 0; y < MaterialMatrix.SIZE_Y; y++)
                {
                    if(!materialMat.IsInactive(0, y))
                    {
                        if (sender_textbox == null || sender_textbox != componentsMatrix[x, y])
                        {
                            if (materialMat[x, y] == 0)
                            {
                                if (!string.IsNullOrWhiteSpace(componentsMatrix[x, y].Text))
                                    componentsMatrix[x, y].Text = "";
                            }
                            else
                            {
                                if (componentsMatrix[x, y].Text != materialMat[x, y].ToString())
                                    componentsMatrix[x, y].Text = materialMat[x, y].ToString();
                            }
                        }
                    }                    
                }
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
                try
                {
                    checkBoxAvailable.Enabled = true;
                    checkBoxAvailable.AutoCheck = false;
                    checkBoxAvailable.Checked = AvailabilityCheck.IsAvailable(obj, materialMat);
                }
                catch (Exception)
                {
                    checkBoxAvailable.Checked = false;
                    checkBoxAvailable.Enabled = false;
                }
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

        private async void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (excelWrapper == null || excelWrapper.GetFilename() != textBoxSourceFile.Text)
            {
                Cursor.Current = Cursors.WaitCursor;
                Settings.Default.sourceFile = textBoxSourceFile.Text;
                Settings.Default.Save();
                Settings.Default.Upgrade();
                LoadExcelWrapper();
                Cursor.Current = Cursors.Default;
            }
            if (materialMat != null && materialMat.CountNonNegativeEntrys() != materialMatLastPosEntrys)
            {
                materialMatLastPosEntrys = materialMat.CountNonNegativeEntrys();
                if (labelStatistics.Text != Statistics.STR_LOADING_STATISTIC_PROG)
                {
                    labelStatistics.Text = Statistics.STR_LOADING_STATISTIC_PROG;
                    string newText = await Task.Run<string>(LoadStatistics);
                    labelStatistics.Text = newText;
                }

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
                Cursor.Current = Cursors.WaitCursor;
                DataSheetCreator dataSheetCreator = new DataSheetCreator(excelWrapper.GetFilename());
                string content = dataSheetCreator.CreateDataSheet(itemList[listSearchResults.SelectedIndex]);
                this.saveFileDialog1.DefaultExt = ".csv";
                this.saveFileDialog1.FileName = itemList[listSearchResults.SelectedIndex][1];
                this.saveFileDialog1.AddExtension = true;
                this.saveFileDialog1.CheckPathExists = true;
                this.saveFileDialog1.Filter = "CSV Dateien | *.csv";
                Cursor.Current = Cursors.Default;
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

        private void exportLagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    materialMat.SaveToFile(saveFileDialog1.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could write file\n" + exc.ToString());
                }
            }
        }

        private void importLagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        materialMat = MaterialMatrix.ReadFromFile(openFileDialog.FileName);
                        // update textboxes
                        components_textchanged(null, null);
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show("Could not read file\n" + exc.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Die Datei konnte nicht gefunden werden");
                }
            }
        }
    }
}

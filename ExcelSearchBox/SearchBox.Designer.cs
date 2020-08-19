namespace ExcelSearchBox
{
    partial class SearchBox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupSearchResults = new System.Windows.Forms.GroupBox();
            this.listSearchResults = new System.Windows.Forms.ListBox();
            this.groupSearchInput = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchString = new System.Windows.Forms.TextBox();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listDetails = new System.Windows.Forms.ListView();
            this.columnPropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPropertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.buttonDatasheet = new System.Windows.Forms.Button();
            this.labelTypeCode = new System.Windows.Forms.Label();
            this.labelDetailName = new System.Windows.Forms.Label();
            this.tabComponents = new System.Windows.Forms.TabPage();
            this.groupComponents = new System.Windows.Forms.GroupBox();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            this.groupSearchInput.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabComponents.SuspendLayout();
            this.groupComponents.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Controls.Add(this.tabDetails);
            this.tabControl.Controls.Add(this.tabComponents);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 68);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1480, 905);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupSearchResults);
            this.tabSearch.Controls.Add(this.groupSearchInput);
            this.tabSearch.Location = new System.Drawing.Point(8, 39);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1464, 858);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Suchen";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSearchResults.Controls.Add(this.listSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(6, 147);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(1443, 700);
            this.groupSearchResults.TabIndex = 1;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Ergebnisse";
            // 
            // listSearchResults
            // 
            this.listSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSearchResults.FormattingEnabled = true;
            this.listSearchResults.ItemHeight = 25;
            this.listSearchResults.Location = new System.Drawing.Point(14, 30);
            this.listSearchResults.Name = "listSearchResults";
            this.listSearchResults.Size = new System.Drawing.Size(1412, 604);
            this.listSearchResults.TabIndex = 0;
            this.listSearchResults.DoubleClick += new System.EventHandler(this.listSearchResults_DoubleClick);
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSearchInput.Controls.Add(this.buttonSearch);
            this.groupSearchInput.Controls.Add(this.label1);
            this.groupSearchInput.Controls.Add(this.textBoxSearchString);
            this.groupSearchInput.Location = new System.Drawing.Point(6, 6);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Size = new System.Drawing.Size(1443, 130);
            this.groupSearchInput.TabIndex = 0;
            this.groupSearchInput.TabStop = false;
            this.groupSearchInput.Text = "Eingabe";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(1253, 50);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(148, 47);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pumpennummer:";
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Location = new System.Drawing.Point(229, 58);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(219, 31);
            this.textBoxSearchString.TabIndex = 0;
            this.textBoxSearchString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchString_KeyPress);
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.groupBox3);
            this.tabDetails.Controls.Add(this.groupBox2);
            this.tabDetails.Location = new System.Drawing.Point(8, 39);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Size = new System.Drawing.Size(1468, 927);
            this.tabDetails.TabIndex = 2;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.listDetails);
            this.groupBox3.Location = new System.Drawing.Point(3, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1462, 769);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // listDetails
            // 
            this.listDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPropertyName,
            this.columnPropertyValue});
            this.listDetails.GridLines = true;
            this.listDetails.HideSelection = false;
            this.listDetails.Location = new System.Drawing.Point(20, 30);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(1436, 733);
            this.listDetails.TabIndex = 0;
            this.listDetails.UseCompatibleStateImageBehavior = false;
            this.listDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnPropertyName
            // 
            this.columnPropertyName.Text = "Eigenschaft";
            this.columnPropertyName.Width = 684;
            // 
            // columnPropertyValue
            // 
            this.columnPropertyValue.Text = "Wert";
            this.columnPropertyValue.Width = 340;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxAvailable);
            this.groupBox2.Controls.Add(this.buttonDatasheet);
            this.groupBox2.Controls.Add(this.labelTypeCode);
            this.groupBox2.Controls.Add(this.labelDetailName);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1456, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Übersicht";
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAvailable.AutoCheck = false;
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAvailable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAvailable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxAvailable.Location = new System.Drawing.Point(1137, 64);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(138, 29);
            this.checkBoxAvailable.TabIndex = 3;
            this.checkBoxAvailable.Text = "Verfügbar";
            this.checkBoxAvailable.UseVisualStyleBackColor = false;
            // 
            // buttonDatasheet
            // 
            this.buttonDatasheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDatasheet.Location = new System.Drawing.Point(1281, 57);
            this.buttonDatasheet.Name = "buttonDatasheet";
            this.buttonDatasheet.Size = new System.Drawing.Size(145, 41);
            this.buttonDatasheet.TabIndex = 2;
            this.buttonDatasheet.Text = "Datenblatt";
            this.buttonDatasheet.UseVisualStyleBackColor = true;
            this.buttonDatasheet.Click += new System.EventHandler(this.buttonDatasheet_Click);
            // 
            // labelTypeCode
            // 
            this.labelTypeCode.AutoSize = true;
            this.labelTypeCode.Location = new System.Drawing.Point(413, 65);
            this.labelTypeCode.Name = "labelTypeCode";
            this.labelTypeCode.Size = new System.Drawing.Size(168, 25);
            this.labelTypeCode.TabIndex = 1;
            this.labelTypeCode.Text = "Typenschlüssel:";
            // 
            // labelDetailName
            // 
            this.labelDetailName.AutoSize = true;
            this.labelDetailName.Location = new System.Drawing.Point(36, 65);
            this.labelDetailName.Name = "labelDetailName";
            this.labelDetailName.Size = new System.Drawing.Size(180, 25);
            this.labelDetailName.TabIndex = 0;
            this.labelDetailName.Text = "Pumpennummer: ";
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.groupComponents);
            this.tabComponents.Location = new System.Drawing.Point(8, 39);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.Padding = new System.Windows.Forms.Padding(3);
            this.tabComponents.Size = new System.Drawing.Size(1468, 927);
            this.tabComponents.TabIndex = 3;
            this.tabComponents.Text = "Lager";
            this.tabComponents.UseVisualStyleBackColor = true;
            // 
            // groupComponents
            // 
            this.groupComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComponents.Controls.Add(this.labelStatistics);
            this.groupComponents.Location = new System.Drawing.Point(6, 6);
            this.groupComponents.Name = "groupComponents";
            this.groupComponents.Size = new System.Drawing.Size(1447, 895);
            this.groupComponents.TabIndex = 0;
            this.groupComponents.TabStop = false;
            this.groupComponents.Text = "Komponenten";
            // 
            // labelStatistics
            // 
            this.labelStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Location = new System.Drawing.Point(6, 790);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(147, 25);
            this.labelStatistics.TabIndex = 300;
            this.labelStatistics.Text = "Statistik lädt...";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(8, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1468, 927);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Einstellungen";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSourceFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1422, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quelldatei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quelldatei";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(182, 62);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(862, 31);
            this.textBoxSourceFile.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1672, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importLagerToolStripMenuItem,
            this.exportLagerToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(91, 38);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // importLagerToolStripMenuItem
            // 
            this.importLagerToolStripMenuItem.Name = "importLagerToolStripMenuItem";
            this.importLagerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.importLagerToolStripMenuItem.Text = "Import Lager";
            this.importLagerToolStripMenuItem.Click += new System.EventHandler(this.importLagerToolStripMenuItem_Click);
            // 
            // exportLagerToolStripMenuItem
            // 
            this.exportLagerToolStripMenuItem.Name = "exportLagerToolStripMenuItem";
            this.exportLagerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportLagerToolStripMenuItem.Text = "Export Lager";
            this.exportLagerToolStripMenuItem.Click += new System.EventHandler(this.exportLagerToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 1206);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SearchBox";
            this.ShowIcon = false;
            this.Text = "ExelSuche";
            this.Shown += new System.EventHandler(this.SearchBox_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupSearchResults.ResumeLayout(false);
            this.groupSearchInput.ResumeLayout(false);
            this.groupSearchInput.PerformLayout();
            this.tabDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabComponents.ResumeLayout(false);
            this.groupComponents.ResumeLayout(false);
            this.groupComponents.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupSearchResults;
        private System.Windows.Forms.ListBox listSearchResults;
        private System.Windows.Forms.GroupBox groupSearchInput;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listDetails;
        private System.Windows.Forms.Label labelDetailName;
        private System.Windows.Forms.ColumnHeader columnPropertyName;
        private System.Windows.Forms.ColumnHeader columnPropertyValue;
        private System.Windows.Forms.Label labelTypeCode;
        private System.Windows.Forms.Button buttonDatasheet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabComponents;
        private System.Windows.Forms.GroupBox groupComponents;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLagerToolStripMenuItem;
    }
}


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
            this.listDetails = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDetailName = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupSearchResults.SuspendLayout();
            this.groupSearchInput.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Controls.Add(this.tabDetails);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1238, 777);
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
            this.tabSearch.Size = new System.Drawing.Size(1222, 730);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Suchen";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupSearchResults
            // 
            this.groupSearchResults.Controls.Add(this.listSearchResults);
            this.groupSearchResults.Location = new System.Drawing.Point(6, 147);
            this.groupSearchResults.Name = "groupSearchResults";
            this.groupSearchResults.Size = new System.Drawing.Size(1210, 577);
            this.groupSearchResults.TabIndex = 1;
            this.groupSearchResults.TabStop = false;
            this.groupSearchResults.Text = "Ergebnisse";
            // 
            // listSearchResults
            // 
            this.listSearchResults.FormattingEnabled = true;
            this.listSearchResults.ItemHeight = 25;
            this.listSearchResults.Location = new System.Drawing.Point(14, 30);
            this.listSearchResults.Name = "listSearchResults";
            this.listSearchResults.Size = new System.Drawing.Size(1178, 529);
            this.listSearchResults.TabIndex = 0;
            this.listSearchResults.DoubleClick += new System.EventHandler(this.listSearchResults_DoubleClick);
            // 
            // groupSearchInput
            // 
            this.groupSearchInput.Controls.Add(this.buttonSearch);
            this.groupSearchInput.Controls.Add(this.label1);
            this.groupSearchInput.Controls.Add(this.textBoxSearchString);
            this.groupSearchInput.Location = new System.Drawing.Point(6, 6);
            this.groupSearchInput.Name = "groupSearchInput";
            this.groupSearchInput.Size = new System.Drawing.Size(1210, 135);
            this.groupSearchInput.TabIndex = 0;
            this.groupSearchInput.TabStop = false;
            this.groupSearchInput.Text = "Eingabe";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(509, 50);
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
            this.tabDetails.Size = new System.Drawing.Size(1222, 730);
            this.tabDetails.TabIndex = 2;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listDetails);
            this.groupBox3.Location = new System.Drawing.Point(3, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1216, 573);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // listDetails
            // 
            this.listDetails.FormattingEnabled = true;
            this.listDetails.ItemHeight = 25;
            this.listDetails.Location = new System.Drawing.Point(20, 30);
            this.listDetails.Name = "listDetails";
            this.listDetails.Size = new System.Drawing.Size(1178, 529);
            this.listDetails.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDetailName);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1216, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Übersicht";
            // 
            // labelDetailName
            // 
            this.labelDetailName.AutoSize = true;
            this.labelDetailName.Location = new System.Drawing.Point(45, 66);
            this.labelDetailName.Name = "labelDetailName";
            this.labelDetailName.Size = new System.Drawing.Size(180, 25);
            this.labelDetailName.TabIndex = 0;
            this.labelDetailName.Text = "Pumpennummer: ";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(8, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1222, 730);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Einstellungen";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSourceFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1190, 139);
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
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 801);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox listDetails;
        private System.Windows.Forms.Label labelDetailName;
    }
}


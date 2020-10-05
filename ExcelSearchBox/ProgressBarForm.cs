using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSearchBox
{
    public partial class ProgressBarForm : Form
    {
        string thingsdone;
        public ProgressBarForm(string thingsdone)
        {
            InitializeComponent();
            this.label1.Text = thingsdone + "  ...  0%";
            this.Text = "ProgressBar for " + thingsdone;
            this.thingsdone = thingsdone;
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        public void SetProgress(int val)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                this.label1.Text = thingsdone + "  ...  "+val+"%";
                progressBar1.Value = val;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

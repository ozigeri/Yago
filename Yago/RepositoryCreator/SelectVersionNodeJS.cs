using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yago.RepositoryCreator
{
    public partial class SelectVersionNodeJS : Form
    {
        public string SelectedNode => sVersionComboBox.SelectedItem?.ToString();
        public bool openBrowser => viteBox.Checked;

        public SelectVersionNodeJS(string[] verType, string node, bool check)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            UIStyleHelpers.StyleButton(Ok);
            UIStyleHelpers.StyleComboBox(sVersionComboBox);
            UIStyleHelpers.StyleLabel(sVersionLabel);
            sVersionComboBox.Items.AddRange(verType);
            sVersionComboBox.Text = node;
            viteBox.Checked = check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

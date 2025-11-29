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

        public bool isTs => tsCheck.Checked;

        public SelectVersionNodeJS(string[] verType, string node, bool check, bool ts)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            UIStyleHelpers.StyleButton(Ok, UIStyleHelpers.ButtonType.OK);
            UIStyleHelpers.StyleButton(Cancel, UIStyleHelpers.ButtonType.Delete);
            UIStyleHelpers.StyleComboBox(sVersionComboBox);
            UIStyleHelpers.StyleLabel(sVersionLabel);
            sVersionComboBox.Items.AddRange(verType);
            sVersionComboBox.Text = node;
            viteBox.Checked = check;
            tsCheck.Checked = ts;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

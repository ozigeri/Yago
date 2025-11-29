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
    public partial class SelectVersionPhp : Form
    {
        public string SelectedPhp => phpBox.SelectedItem?.ToString();
        public string SelectedComposer => composerBox.SelectedItem?.ToString();

        public SelectVersionPhp(string[] php, string[] composer, string phpd, string composerd)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            UIStyleHelpers.StyleButton(Ok, UIStyleHelpers.ButtonType.OK);
            UIStyleHelpers.StyleButton(Cancel, UIStyleHelpers.ButtonType.Delete);
            UIStyleHelpers.StyleComboBox(phpBox);
            UIStyleHelpers.StyleComboBox(composerBox);
            UIStyleHelpers.StyleLabel(phpL);
            UIStyleHelpers.StyleLabel(ComposerL);

            phpBox.Items.AddRange(php);
            composerBox.Items.AddRange(composer);
            phpBox.Text = phpd;
            composerBox.Text = composerd;

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}

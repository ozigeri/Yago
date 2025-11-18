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
            DoubleBuffered = true;
            UIStyleHelpers.StyleComboBox(phpBox);
            UIStyleHelpers.StyleComboBox(composerBox);

            UIStyleHelpers.StyleLabel(phpL);
            UIStyleHelpers.StyleLabel(ComposerL);

            UIStyleHelpers.StyleButton(Ok);

            phpBox.Items.AddRange(php);
            composerBox.Items.AddRange(composer);
            phpBox.Text = phpd;
            composerBox.Text = composerd;

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

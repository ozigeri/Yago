using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Yago.RepositoryCreator.RCEnums;

namespace Yago.RepositoryCreator
{
    public partial class FormRepositoryCreator : Form
    {
        public FormRepositoryCreator()
        {
            InitializeComponent();
            appBox.DataSource = Enum.GetValues(typeof(App));

            UIStyleHelpers.ApplyFormStyle(this);

            UIStyleHelpers.StyleButton(repoButton);
            UIStyleHelpers.StyleButton(versionButton);
            UIStyleHelpers.StyleButton(pathButton);

            UIStyleHelpers.StyleComboBox(appBox);

            UIStyleHelpers.StyleTextBox(nameBox);
            UIStyleHelpers.StyleTextBox(pathBox);

            UIStyleHelpers.StyleLabel(nameL);
            UIStyleHelpers.StyleLabel(pathL);
            UIStyleHelpers.StyleLabel(appL);
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            pathBox.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.RepositoryCreator.RCEnums;

namespace Yago.RepositoryCreator
{
    public partial class FormRepositoryCreator : Form
    {
        public FormRepositoryCreator()
        {
            InitializeComponent();
            appBox.DataSource = Enum.GetValues(typeof(App));
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            pathBox.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}

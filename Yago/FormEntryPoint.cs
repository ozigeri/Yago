using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Versions;
using Yago.RepositoryCreator;
using Yago.Templates;


namespace Yago
{
    public partial class FormEntryPoint : Form
    {
        public FormEntryPoint()
        {
            InitializeComponent();

            DoubleBuffered = true;
            UIStyleHelpers.ApplyFormStyle(this);

            UIStyleHelpers.StyleButton(btnVersions);
            UIStyleHelpers.StyleButton(btnRepoCreator);
            UIStyleHelpers.StyleButton(btnTemplates);
        }

        private void FormEntryPoint_Load(object sender, EventArgs e)
        {

        }

        private void LoadFormInPanel(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void btnVersions_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormVersions());
        }

        private void btnRepoCreator_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormRepositoryCreator());
        }

        private void btnTemplates_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FormTemplates());
        }
    }
}

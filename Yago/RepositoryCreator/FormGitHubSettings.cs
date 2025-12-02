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
    public partial class FormGitHubSettings : Form
    {
        public FormGitHubSettings()
        {
            InitializeComponent();
            userBox.Text = Properties.Settings.Default.GitHubUsername;
            tokenBox.Text = Properties.Settings.Default.GitHubToken;
        }
        private bool GHValidation()
        {
            if (string.IsNullOrWhiteSpace(userBox.Text) || string.IsNullOrWhiteSpace(tokenBox.Text))
            {
                MessageBox.Show("Kérlek töltsd ki mindkét mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!tokenBox.Text.StartsWith("ghp_") && !tokenBox.Text.StartsWith("github_pat_"))
            {
                var result = MessageBox.Show("A token formátuma nem megfelelő! ('ghp_' vagy 'github_pat_') kezdetű.", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GHValidation())
            {
                Properties.Settings.Default.GitHubUsername = userBox.Text;
                Properties.Settings.Default.GitHubToken = tokenBox.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Sikeres mentés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Xml.Linq;
using Yago.RepositoryCreator.RCEnums;
using Yago.Versions.Core;
using Yago.Versions.Enums;
using Yago.RepositoryCreator.CMD;
using System.Collections;
using System.Net.NetworkInformation;
using System.IO;

namespace Yago.RepositoryCreator
{
    public partial class FormRepositoryCreator : Form
    {
        string php, composer, nodeJs;
        bool opensBrowser = false;
        bool isTypeScript = false;
        public FormRepositoryCreator()
        {
            php = Properties.Settings.Default.LastPhp;
            composer = Properties.Settings.Default.LastComposer;
            nodeJs = Properties.Settings.Default.LastNode;
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            appBox.DataSource = Enum.GetValues(typeof(App));
            ideComboBox.DataSource = Enum.GetValues(typeof(EditorTypes));

            UIStyleHelpers.ApplyFormStyle(this);
            UIStyleHelpers.StyleLabel(GitLabel);
            UIStyleHelpers.StyleLabel(ideLabel);
            UIStyleHelpers.StyleComboBox(ideComboBox);
            UIStyleHelpers.StyleButton(repoButton, UIStyleHelpers.ButtonType.OK);
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void versionButton_Click(object sender, EventArgs e)
        {
            if (appBox.SelectedItem == null)
            {
                if (!string.IsNullOrWhiteSpace(appBox.Text) && Enum.TryParse<App>(appBox.Text, true, out App result))
                {
                    appBox.SelectedItem = result;
                }
                else
                {
                    ShowError("Kérlek előbb válassz framework-öt!");
                    return;
                }
   
            }

            if (appBox.SelectedItem.ToString() == App.Laravel.ToString())
            {
                OpenPhpSelector();

            }
            else
            {
                OpenNodeSelector();

            }

        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            if (!IsInternetAvailable())
            {
                ShowError("Nincs internetkapcsolat! A telepítéshez internet szükséges.");
                return;
            }

            if (!ValidateBasicInputs()) return;

            string selectedApp = appBox.SelectedItem.ToString();
            string selectedEditor = ideComboBox.SelectedItem.ToString();

            if (selectedApp == App.Laravel.ToString())
            {
                CreateLaravelRepository(selectedApp, selectedEditor);
            }
            else
            {
                CreateNodeRepository(selectedApp, selectedEditor);
            }
        }

        private void CreateLaravelRepository(string appName, string selectedEditor)
        {
            if (string.IsNullOrWhiteSpace(composer))
            {
                ShowError("Add meg a composer verzióját!");
                return;
            }
            if (string.IsNullOrWhiteSpace(php))
            {
                ShowError("Add meg a php verzióját!");
                return;
            }

            phpCMDCommand pCMDC = new phpCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, php, composer);
            pCMDC.Execute(GitInitCheck.Checked, selectedEditor);

            Properties.Settings.Default.LastPhp = php;
            Properties.Settings.Default.LastComposer = composer;
            Properties.Settings.Default.Save();
        }

        private void CreateNodeRepository(string appName, string selectedEditor)
        {
            if (string.IsNullOrWhiteSpace(nodeJs))
            {
                ShowError("Add meg a Node.js verzióját!");
                return;
            }

            NodeCMDCommand nCMDC = new NodeCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, nodeJs);
            nCMDC.Execute(opensBrowser, GitInitCheck.Checked, isTypeScript, selectedEditor);

            Properties.Settings.Default.LastNode = nodeJs;
            Properties.Settings.Default.Save();
        }

        private void OpenPhpSelector()
        {
            var phpVersions = EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray();
            var composerVersions = EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray();

            var selector = new SelectVersionPhp(phpVersions, composerVersions, php, composer);

            selector.StartPosition = FormStartPosition.CenterParent;

            if (selector.ShowDialog() == DialogResult.OK)
            {
                php = selector.SelectedPhp;
                composer = selector.SelectedComposer;

                nodeJs = null;
            }
        }

        private void OpenNodeSelector()
        {
            var nodeVersions = EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray();

            var selector = new SelectVersionNodeJS(nodeVersions, nodeJs, opensBrowser, isTypeScript);

            selector.StartPosition = FormStartPosition.CenterParent;

            if (selector.ShowDialog() == DialogResult.OK)
            {
                nodeJs = selector.SelectedNode;
                opensBrowser = selector.openBrowser;
                isTypeScript = selector.isTs;

                composer = null;
                php = null;
            }
        }
        private bool ValidateBasicInputs()
        {
            if (appBox.SelectedItem == null || string.IsNullOrWhiteSpace(appBox.SelectedItem.ToString()))
            {
                ShowError("Add meg a frameworkot!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                ShowError("Add meg a cél mappa nevét!");
                return false;
            }
            if (!Directory.Exists(pathBox.Text))
            {
                ShowError("A megadott cél mappa elérési útvonal nem létezik!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pathBox.Text) || pathBox.Text == "Elérési útvonal...")
            {
                ShowError("Add meg a cél mappa elérési útvonalát!");
                return false;
            }

            return true;
        }


        private void ShowError(string message)
        {
            MessageBox.Show(message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("8.8.8.8", 1000);
                    return reply != null && reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
        private void GitAuth_Click(object sender, EventArgs e)
        {
            FormGitHubSettings settingsForm = new FormGitHubSettings();
            settingsForm.StartPosition = FormStartPosition.CenterParent;
            settingsForm.ShowDialog();
        }
    }
}

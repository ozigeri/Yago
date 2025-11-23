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

namespace Yago.RepositoryCreator
{
    public partial class FormRepositoryCreator : Form
    {
        string php, composer, nodeJs;
        bool check = false;
        public FormRepositoryCreator()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void versionButton_Click(object sender, EventArgs e)
        {
            if (appBox.SelectedItem == null)
            {
                ShowError("Kérlek előbb válassz framework-öt!");
                return;
            }

            if (appBox.SelectedItem.ToString() == App.Laravel.ToString())
            {
                SelectVersionPhp selectVersion = new SelectVersionPhp(EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray(), EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray(), php, composer);
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();
                php = selectVersion.SelectedPhp;
                composer = selectVersion.SelectedComposer;
                nodeJs = null;
            }
            else
            {
                SelectVersionNodeJS selectVersion = new SelectVersionNodeJS(EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray(), nodeJs, check);
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();
                nodeJs = selectVersion.SelectedNode;
                composer = null;
                php = null;
                check = selectVersion.openBrowser;
            }

        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            if (!ValidateBasicInputs()) return;

            string selectedApp = appBox.SelectedItem.ToString();


            if (selectedApp == App.Laravel.ToString())
            {
                CreateLaravelRepository(selectedApp);
            }
            else
            {
                CreateNodeRepository(selectedApp);
            }
        }

        private void CreateLaravelRepository(string appName)
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
            pCMDC.Execute();
        }

        private void CreateNodeRepository(string appName)
        {
            if (string.IsNullOrWhiteSpace(nodeJs))
            {
                ShowError("Add meg a Node.js verzióját!");
                return;
            }

            NodeCMDCommand nCMDC = new NodeCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, nodeJs);
            nCMDC.Execute(check);
        }

        private bool ValidateBasicInputs()
        {
            if (string.IsNullOrWhiteSpace(appBox.SelectedItem.ToString()))
            {
                ShowError("Add meg a frameworkot!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                ShowError("Add meg a cél mappa nevét!");
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
    }
}

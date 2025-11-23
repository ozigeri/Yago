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
        string php, composer, nodeJs, type;
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
            folderBrowserDialog1.ShowDialog();
            pathBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void versionButton_Click(object sender, EventArgs e)
        {


            if (appBox.SelectedItem.ToString() == App.Laravel.ToString())
            {
                SelectVersionPhp selectVersion = new SelectVersionPhp(EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray(), EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray(), php, composer);
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();
                php = selectVersion.SelectedPhp;
                composer = selectVersion.SelectedComposer;
                nodeJs = null;
                type = "laravel";
            }
            else
            {
                SelectVersionNodeJS selectVersion = new SelectVersionNodeJS(EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray(), nodeJs, check);
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();
                nodeJs = selectVersion.SelectedNode;
                composer = null;
                php = null;
                type = "nemLaravel";
                check = selectVersion.openBrowser;
            }

            

        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Add meg a frameworkot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Add meg a cél mappa nevét!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(pathBox.Text) || pathBox.Text == "Elérési útvonal...")
            {
                MessageBox.Show("Add meg a cél mappa elérési útvonalát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (type == "nemLaravel")
            {
                if (string.IsNullOrWhiteSpace(nodeJs))
                {
                    MessageBox.Show("Add meg a Node.js verzióját!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                NodeCMDCommand nCMDC = new NodeCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, nodeJs);
                nCMDC.Execute(check);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(composer))
                {
                    MessageBox.Show("Add meg a composer verzióját!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(php))
                {
                    MessageBox.Show("Add meg a php verzióját!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                phpCMDCommand pCMDC = new phpCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, php, composer);
                pCMDC.Execute();

            }
        }
    }
}

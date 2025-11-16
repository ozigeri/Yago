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

        private void versionButton_Click(object sender, EventArgs e)
        {


            if (appBox.SelectedItem.ToString() == App.Laravel.ToString())
            {
                SelectVersionPhp selectVersion = new SelectVersionPhp(EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray(), EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray());
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();

                php = selectVersion.SelectedPhp;
                composer = selectVersion.SelectedComposer;
                nodeJs = null;
            }
            else
            {
                SelectVersionNodeJS selectVersion = new SelectVersionNodeJS(EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray());
                selectVersion.StartPosition = FormStartPosition.CenterParent;
                selectVersion.ShowDialog();
                nodeJs = selectVersion.SelectedNode;
                composer = null;
                php = null;
            }

            

        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nodeJs))
            {
                NodeCMDCommand nCMDC = new NodeCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, nodeJs);
                nCMDC.Execute();
            }

            if (!string.IsNullOrEmpty(php) && !string.IsNullOrEmpty(composer))
            {
                phpCMDCommand pCMDC = new phpCMDCommand(appBox.SelectedItem.ToString(), nameBox.Text, pathBox.Text, php, composer);
                pCMDC.Execute();
            }
        }
    }
}

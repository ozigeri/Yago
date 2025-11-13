using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Versions.Core;
using Yago.Versions.Enums;

namespace Yago.Versions.Commands
{
    public class EnvironmentController
    {
        private readonly ComboBox phpBox;
        private readonly ComboBox composerBox;
        private readonly ComboBox nodeBox;
        private readonly ComboBox templateLoadBox;
        private readonly TextBox templateNameBox;
        private readonly Button startButton;
        private readonly Button saveTemplateButton;
        private readonly Button btnTemplateLoad;

        public EnvironmentController(
            ComboBox phpBox,
            ComboBox composerBox,
            ComboBox nodeBox,
            ComboBox templateLoadBox,
            TextBox templateNameBox,
            Button startButton,
            Button saveTemplateButton,
            Button btnTemplateLoad)
        {
            this.phpBox = phpBox;
            this.composerBox = composerBox;
            this.nodeBox = nodeBox;
            this.templateLoadBox = templateLoadBox;
            this.templateNameBox = templateNameBox;
            this.startButton = startButton;
            this.saveTemplateButton = saveTemplateButton;
            this.btnTemplateLoad = btnTemplateLoad;

            Initialize();
        }

        private void Initialize()
        {
            LoadVersions();
        }

        private void LoadVersions()
        {
            phpBox.Items.Clear();
            composerBox.Items.Clear();
            nodeBox.Items.Clear();

            phpBox.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray());
            composerBox.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray());
            nodeBox.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray());

            if (phpBox.Items.Count > 0) phpBox.SelectedIndex = 0;
            if (composerBox.Items.Count > 0) composerBox.SelectedIndex = 0;
            if (nodeBox.Items.Count > 0) nodeBox.SelectedIndex = 0;
        }
    }
}

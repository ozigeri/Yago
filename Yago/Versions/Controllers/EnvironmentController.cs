using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Commands;
using Yago.Versions.Core;
using Yago.Versions.Enums;

namespace Yago.Versions.Controllers
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
        private readonly Button btnPaths;

        public EnvironmentController(
            ComboBox phpBox,
            ComboBox composerBox,
            ComboBox nodeBox,
            ComboBox templateLoadBox,
            TextBox templateNameBox,
            Button startButton,
            Button saveTemplateButton,
            Button btnTemplateLoad,
            Button btnPaths)
        {
            this.phpBox = phpBox;
            this.composerBox = composerBox;
            this.nodeBox = nodeBox;
            this.templateLoadBox = templateLoadBox;
            this.templateNameBox = templateNameBox;
            this.startButton = startButton;
            this.saveTemplateButton = saveTemplateButton;
            this.btnTemplateLoad = btnTemplateLoad;
            this.btnPaths = btnPaths;

            Initialize();
        }

        private void Initialize()
        {
            EnvironmentManager.LoadPathsFromFile();

            LoadVersions();

            startButton.Click += StartButton_Click;
            saveTemplateButton.Click += SaveTemplateButton_Click;

            templateLoadBox.SelectedIndex = -1;

            TemplateManager.InitializeTemplateComboBox(templateLoadBox);

            btnTemplateLoad.Click += TemplateLoadButton_Click;

            btnPaths.Click += BtnPaths_Click;
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

        private void BtnPaths_Click(object sender, EventArgs e)
        {
            using (FormPathConfig popupWindow = new FormPathConfig())
            {
                if (popupWindow.ShowDialog() == DialogResult.OK)
                {
                    LoadVersions();
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string php = phpBox.SelectedItem?.ToString();
            string composer = composerBox.SelectedItem?.ToString();
            string node = nodeBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(php) || string.IsNullOrEmpty(composer) || string.IsNullOrEmpty(node))
            {
                MessageBox.Show("Kérlek válaszd ki mindhárom verziót!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phpPath = $"{EnvironmentManager.BasePaths[VersionType.Php]}\\php{php}";
            string composerPath = $"{EnvironmentManager.BasePaths[VersionType.Composer]}\\v{composer}";
            string nodePath = $"{EnvironmentManager.BasePaths[VersionType.NodeJs]}\\v{node}";

            OpenCmdCommand openCmd = new OpenCmdCommand(phpPath, composerPath, nodePath);
            openCmd.Execute();
        }
        private void SaveTemplateButton_Click(object sender, EventArgs e)
        {
            string name = templateNameBox.Text.Trim();
            string php = phpBox.SelectedItem?.ToString();
            string composer = composerBox.SelectedItem?.ToString();
            string node = nodeBox.SelectedItem?.ToString();

            TemplateManager.SaveTemplate(name, php, composer, node);

            TemplateManager.InitializeTemplateComboBox(templateLoadBox);
        }
        private void TemplateLoadButton_Click(object sender, EventArgs e)
        {
            if (templateLoadBox.SelectedItem == null)
            {
                MessageBox.Show("Kérlek válassz ki egy sablont!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTemplate = templateLoadBox.SelectedItem.ToString();
            var result = TemplateManager.LoadTemplate(selectedTemplate);

            if (!result.HasValue)
            {
                MessageBox.Show("Nem sikerült betölteni a sablont!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phpBox.SelectedItem = result.Value.php;
            composerBox.SelectedItem = result.Value.composer;
            nodeBox.SelectedItem = result.Value.node;

            MessageBox.Show($"'{selectedTemplate}' sablon sikeresen betöltve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

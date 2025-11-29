using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Templates.Methods;
using Yago.Versions.Controllers;
using Yago.Versions.Core;
using Yago.Versions.Enums;

namespace Yago.Templates
{
    public partial class EditTemplate : Form
    {
        private string templateName;
        private TemplateItem currentTemplate;

        public EditTemplate(string name)
        {
            InitializeComponent();
            templateName = name;

            this.FormBorderStyle = FormBorderStyle.None;

            UIStyleHelpers.StyleLabel(lName);
            UIStyleHelpers.StyleLabel(labelPhp);
            UIStyleHelpers.StyleLabel(labelComposer);
            UIStyleHelpers.StyleLabel(labelNode);

            UIStyleHelpers.StyleComboBox(comboPhp);
            UIStyleHelpers.StyleComboBox(comboComposer);
            UIStyleHelpers.StyleComboBox(comboNode);

            UIStyleHelpers.StyleButton(btnCancel, UIStyleHelpers.ButtonType.Delete);
            UIStyleHelpers.StyleButton(btnSave, UIStyleHelpers.ButtonType.OK);
        }

        private void EditTemplate_Load(object sender, EventArgs e)
        {
            
            currentTemplate = TemplateMethods.GetTemplateByName(templateName);

            lName.Text = currentTemplate.Name;

            
            comboPhp.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.Php).ToArray());
            comboComposer.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.Composer).ToArray());
            comboNode.Items.AddRange(EnvironmentManager.GetSoftwareVersion(VersionType.NodeJs).ToArray());

            comboPhp.SelectedItem = currentTemplate.Php;
            comboComposer.SelectedItem = currentTemplate.Composer;
            comboNode.SelectedItem = currentTemplate.Node;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentTemplate.Php = comboPhp.SelectedItem.ToString();
            currentTemplate.Composer = comboComposer.SelectedItem.ToString();
            currentTemplate.Node = comboNode.SelectedItem.ToString();

            TemplateMethods.SaveTemplate(currentTemplate);

            MessageBox.Show("A sablon sikeresen elmentve!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A módosítások nem lettek mentve.", "Kilépés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}

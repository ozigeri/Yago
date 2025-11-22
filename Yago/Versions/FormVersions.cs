using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Versions.Controllers;
using Yago;

namespace Yago.Versions
{
    public partial class FormVersions : Form
    {
        public FormVersions()
        {
            InitializeComponent();

            DoubleBuffered = true;
            UIStyleHelpers.ApplyFormStyle(this);

            UIStyleHelpers.StyleButton(btnStart);
            UIStyleHelpers.StyleButton(btnTemplateSave);
            UIStyleHelpers.StyleButton(btnTemplateLoad);
            UIStyleHelpers.StyleButton(btnPaths);

            UIStyleHelpers.StyleComboBox(comboBoxPhp);
            UIStyleHelpers.StyleComboBox(comboBoxComposer);
            UIStyleHelpers.StyleComboBox(comboBoxNode);
            UIStyleHelpers.StyleComboBox(comboBoxTemplateLoad);

            UIStyleHelpers.StyleTextBox(textBoxTemplateSave);

            UIStyleHelpers.StyleLabel(lblPhp);
            UIStyleHelpers.StyleLabel(lblComposer);
            UIStyleHelpers.StyleLabel(lblNode);

            EnvironmentController _ = new EnvironmentController(
                comboBoxPhp,
                comboBoxComposer,
                comboBoxNode,
                comboBoxTemplateLoad,
                textBoxTemplateSave,
                btnStart,
                btnTemplateSave,
                btnTemplateLoad,
                btnPaths
            );
        }
    }
}

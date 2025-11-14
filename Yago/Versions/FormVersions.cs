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

namespace Yago.Versions
{
    public partial class FormVersions : Form
    {
        public FormVersions()
        {
            InitializeComponent();

            EnvironmentController controller = new EnvironmentController(
                comboBoxPhp,
                comboBoxComposer,
                comboBoxNode,
                comboBoxTemplateLoad,
                textBoxTemplateSave,
                btnStart,
                btnTemplateSave,
                btnTemplateLoad
            );
        }
    }
}

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
    public partial class FormPathConfig : Form
    {
        public FormPathConfig()
        {
            InitializeComponent();

            PathController controller = new PathController(
            txtPhp,
            txtNode,
            txtComposer,
            btnPhpBrowse,
            btnNodeBrowse,
            btnComposerBrowse,
            btnOk,
            btnCancel,
            folderBrowserDialog1
        );
        }
    }
}

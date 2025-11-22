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

            DoubleBuffered = true;
            UIStyleHelpers.ApplyFormStyle(this);

            UIStyleHelpers.StyleButton(btnPhpBrowse);
            UIStyleHelpers.StyleButton(btnComposerBrowse);
            UIStyleHelpers.StyleButton(btnNodeBrowse);
            UIStyleHelpers.StyleButton(btnOk);
            UIStyleHelpers.StyleButton(btnCancel);

            UIStyleHelpers.StyleTextBox(txtPhp);
            UIStyleHelpers.StyleTextBox(txtComposer);
            UIStyleHelpers.StyleTextBox(txtNode);


            UIStyleHelpers.StyleLabel(lblPhp);
            UIStyleHelpers.StyleLabel(lblComposer);
            UIStyleHelpers.StyleLabel(lblNode);

            PathController _ = new PathController(
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

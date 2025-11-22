using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Versions.Core;
using Yago.Versions.Enums;

namespace Yago.Versions.Controllers
{
    internal class PathController
    {
        private readonly TextBox txtPhp;
        private readonly TextBox txtNode;
        private readonly TextBox txtComposer;

        private readonly Button btnPhpBrowse;
        private readonly Button btnNodeBrowse;
        private readonly Button btnComposerBrowse;

        private readonly Button btnOk;
        private readonly Button btnCancel;

        private readonly FolderBrowserDialog folderDialog;

        public PathController(
            TextBox txtPhp,
            TextBox txtNode,
            TextBox txtComposer,
            Button btnPhpBrowse,
            Button btnNodeBrowse,
            Button btnComposerBrowse,
            Button btnOk,
            Button btnCancel,
            FolderBrowserDialog folderDialog)
        {
            this.txtPhp = txtPhp;
            this.txtNode = txtNode;
            this.txtComposer = txtComposer;

            this.btnPhpBrowse = btnPhpBrowse;
            this.btnNodeBrowse = btnNodeBrowse;
            this.btnComposerBrowse = btnComposerBrowse;

            this.btnOk = btnOk;
            this.btnCancel = btnCancel;

            this.folderDialog = folderDialog;

            Initialize();

        }
        private void Initialize()
        {
            txtPhp.Text = EnvironmentManager.BasePaths[VersionType.Php];
            txtNode.Text = EnvironmentManager.BasePaths[VersionType.NodeJs];
            txtComposer.Text = EnvironmentManager.BasePaths[VersionType.Composer];

            btnPhpBrowse.Click += (s, e) => Browse(txtPhp);
            btnNodeBrowse.Click += (s, e) => Browse(txtNode);
            btnComposerBrowse.Click += (s, e) => Browse(txtComposer);

            btnOk.Click += BtnOk_Click;
            btnCancel.Click += (s, e) =>
            {
                ((Form)txtPhp.FindForm()).DialogResult = DialogResult.Cancel;
            };

        }
        private void Browse(TextBox target)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                target.Text = folderDialog.SelectedPath;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            EnvironmentManager.BasePaths[VersionType.Php] = txtPhp.Text;
            EnvironmentManager.BasePaths[VersionType.NodeJs] = txtNode.Text;
            EnvironmentManager.BasePaths[VersionType.Composer] = txtComposer.Text;

            ((Form)txtPhp.FindForm()).DialogResult = DialogResult.OK;
        }
    }
}

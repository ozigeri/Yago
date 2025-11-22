namespace Yago.Versions
{
    partial class FormPathConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhp = new System.Windows.Forms.Label();
            this.lblCompser = new System.Windows.Forms.Label();
            this.lblNode = new System.Windows.Forms.Label();
            this.txtPhp = new System.Windows.Forms.TextBox();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnPhpBrowse = new System.Windows.Forms.Button();
            this.btnComposerBrowse = new System.Windows.Forms.Button();
            this.btnNodeBrowse = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblPhp
            // 
            this.lblPhp.AutoSize = true;
            this.lblPhp.Location = new System.Drawing.Point(51, 29);
            this.lblPhp.Name = "lblPhp";
            this.lblPhp.Size = new System.Drawing.Size(64, 13);
            this.lblPhp.TabIndex = 0;
            this.lblPhp.Text = "PHP mappa";
            // 
            // lblCompser
            // 
            this.lblCompser.AutoSize = true;
            this.lblCompser.Location = new System.Drawing.Point(26, 81);
            this.lblCompser.Name = "lblCompser";
            this.lblCompser.Size = new System.Drawing.Size(89, 13);
            this.lblCompser.TabIndex = 1;
            this.lblCompser.Text = "Composer mappa";
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.Location = new System.Drawing.Point(47, 129);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(68, 13);
            this.lblNode.TabIndex = 2;
            this.lblNode.Text = "Node mappa";
            // 
            // txtPhp
            // 
            this.txtPhp.Location = new System.Drawing.Point(121, 26);
            this.txtPhp.Name = "txtPhp";
            this.txtPhp.Size = new System.Drawing.Size(100, 20);
            this.txtPhp.TabIndex = 3;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(121, 78);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(100, 20);
            this.txtComposer.TabIndex = 4;
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(121, 129);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(100, 20);
            this.txtNode.TabIndex = 5;
            // 
            // btnPhpBrowse
            // 
            this.btnPhpBrowse.Location = new System.Drawing.Point(227, 26);
            this.btnPhpBrowse.Name = "btnPhpBrowse";
            this.btnPhpBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPhpBrowse.TabIndex = 6;
            this.btnPhpBrowse.Text = "Browse";
            this.btnPhpBrowse.UseVisualStyleBackColor = true;
            // 
            // btnComposerBrowse
            // 
            this.btnComposerBrowse.Location = new System.Drawing.Point(227, 76);
            this.btnComposerBrowse.Name = "btnComposerBrowse";
            this.btnComposerBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnComposerBrowse.TabIndex = 7;
            this.btnComposerBrowse.Text = "Browse";
            this.btnComposerBrowse.UseVisualStyleBackColor = true;
            // 
            // btnNodeBrowse
            // 
            this.btnNodeBrowse.Location = new System.Drawing.Point(227, 127);
            this.btnNodeBrowse.Name = "btnNodeBrowse";
            this.btnNodeBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnNodeBrowse.TabIndex = 8;
            this.btnNodeBrowse.Text = "Browse";
            this.btnNodeBrowse.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(80, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormPathConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 252);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNodeBrowse);
            this.Controls.Add(this.btnComposerBrowse);
            this.Controls.Add(this.btnPhpBrowse);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.txtPhp);
            this.Controls.Add(this.lblNode);
            this.Controls.Add(this.lblCompser);
            this.Controls.Add(this.lblPhp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPathConfig";
            this.ShowIcon = false;
            this.Text = "FormPathConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhp;
        private System.Windows.Forms.Label lblCompser;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.TextBox txtPhp;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnPhpBrowse;
        private System.Windows.Forms.Button btnComposerBrowse;
        private System.Windows.Forms.Button btnNodeBrowse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
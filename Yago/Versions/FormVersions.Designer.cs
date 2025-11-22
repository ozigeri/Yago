namespace Yago.Versions
{
    partial class FormVersions
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
            this.lblComposer = new System.Windows.Forms.Label();
            this.lblNode = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTemplateSave = new System.Windows.Forms.Button();
            this.btnTemplateLoad = new System.Windows.Forms.Button();
            this.comboBoxPhp = new System.Windows.Forms.ComboBox();
            this.comboBoxComposer = new System.Windows.Forms.ComboBox();
            this.comboBoxNode = new System.Windows.Forms.ComboBox();
            this.comboBoxTemplateLoad = new System.Windows.Forms.ComboBox();
            this.textBoxTemplateSave = new System.Windows.Forms.TextBox();
            this.btnPaths = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhp
            // 
            this.lblPhp.AutoSize = true;
            this.lblPhp.Location = new System.Drawing.Point(57, 46);
            this.lblPhp.Name = "lblPhp";
            this.lblPhp.Size = new System.Drawing.Size(61, 13);
            this.lblPhp.TabIndex = 3;
            this.lblPhp.Text = "PHP Verzió";
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.Location = new System.Drawing.Point(22, 88);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(86, 13);
            this.lblComposer.TabIndex = 4;
            this.lblComposer.Text = "Composer Verzió";
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.Location = new System.Drawing.Point(51, 134);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(65, 13);
            this.lblNode.TabIndex = 5;
            this.lblNode.Text = "Node Verzió";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 172);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(212, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Enviroment indítása";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnTemplateSave
            // 
            this.btnTemplateSave.Location = new System.Drawing.Point(54, 304);
            this.btnTemplateSave.Name = "btnTemplateSave";
            this.btnTemplateSave.Size = new System.Drawing.Size(198, 36);
            this.btnTemplateSave.TabIndex = 8;
            this.btnTemplateSave.Text = "Template mentése";
            this.btnTemplateSave.UseVisualStyleBackColor = true;
            // 
            // btnTemplateLoad
            // 
            this.btnTemplateLoad.Location = new System.Drawing.Point(311, 304);
            this.btnTemplateLoad.Name = "btnTemplateLoad";
            this.btnTemplateLoad.Size = new System.Drawing.Size(196, 36);
            this.btnTemplateLoad.TabIndex = 9;
            this.btnTemplateLoad.Text = "Template betöltése";
            this.btnTemplateLoad.UseVisualStyleBackColor = true;
            // 
            // comboBoxPhp
            // 
            this.comboBoxPhp.FormattingEnabled = true;
            this.comboBoxPhp.Location = new System.Drawing.Point(174, 43);
            this.comboBoxPhp.Name = "comboBoxPhp";
            this.comboBoxPhp.Size = new System.Drawing.Size(212, 21);
            this.comboBoxPhp.TabIndex = 0;
            // 
            // comboBoxComposer
            // 
            this.comboBoxComposer.FormattingEnabled = true;
            this.comboBoxComposer.Location = new System.Drawing.Point(174, 85);
            this.comboBoxComposer.Name = "comboBoxComposer";
            this.comboBoxComposer.Size = new System.Drawing.Size(212, 21);
            this.comboBoxComposer.TabIndex = 1;
            // 
            // comboBoxNode
            // 
            this.comboBoxNode.FormattingEnabled = true;
            this.comboBoxNode.Location = new System.Drawing.Point(174, 131);
            this.comboBoxNode.Name = "comboBoxNode";
            this.comboBoxNode.Size = new System.Drawing.Size(212, 21);
            this.comboBoxNode.TabIndex = 2;
            // 
            // comboBoxTemplateLoad
            // 
            this.comboBoxTemplateLoad.FormattingEnabled = true;
            this.comboBoxTemplateLoad.Location = new System.Drawing.Point(311, 277);
            this.comboBoxTemplateLoad.Name = "comboBoxTemplateLoad";
            this.comboBoxTemplateLoad.Size = new System.Drawing.Size(196, 21);
            this.comboBoxTemplateLoad.TabIndex = 10;
            // 
            // textBoxTemplateSave
            // 
            this.textBoxTemplateSave.Location = new System.Drawing.Point(54, 278);
            this.textBoxTemplateSave.Name = "textBoxTemplateSave";
            this.textBoxTemplateSave.Size = new System.Drawing.Size(196, 20);
            this.textBoxTemplateSave.TabIndex = 7;
            // 
            // btnPaths
            // 
            this.btnPaths.Location = new System.Drawing.Point(174, 227);
            this.btnPaths.Name = "btnPaths";
            this.btnPaths.Size = new System.Drawing.Size(212, 30);
            this.btnPaths.TabIndex = 11;
            this.btnPaths.Text = "Verzió elérési útvonalak módosítása";
            this.btnPaths.UseVisualStyleBackColor = true;
            // 
            // FormVersions
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnPaths);
            this.Controls.Add(this.textBoxTemplateSave);
            this.Controls.Add(this.comboBoxTemplateLoad);
            this.Controls.Add(this.comboBoxNode);
            this.Controls.Add(this.comboBoxComposer);
            this.Controls.Add(this.comboBoxPhp);
            this.Controls.Add(this.btnTemplateLoad);
            this.Controls.Add(this.btnTemplateSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNode);
            this.Controls.Add(this.lblComposer);
            this.Controls.Add(this.lblPhp);
            this.Name = "FormVersions";
            this.Text = "Versions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhp;
        private System.Windows.Forms.Label lblComposer;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnTemplateSave;
        private System.Windows.Forms.Button btnTemplateLoad;
        private System.Windows.Forms.ComboBox comboBoxPhp;
        private System.Windows.Forms.ComboBox comboBoxComposer;
        private System.Windows.Forms.ComboBox comboBoxNode;
        private System.Windows.Forms.ComboBox comboBoxTemplateLoad;
        private System.Windows.Forms.TextBox textBoxTemplateSave;
        private System.Windows.Forms.Button btnPaths;
    }
}
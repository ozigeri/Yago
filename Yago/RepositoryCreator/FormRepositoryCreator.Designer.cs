namespace Yago.RepositoryCreator
{
    partial class FormRepositoryCreator
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
            this.appL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.pathL = new System.Windows.Forms.Label();
            this.appBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.versionButton = new System.Windows.Forms.Button();
            this.repoButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GitLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // appL
            // 
            this.appL.AutoSize = true;
            this.appL.Location = new System.Drawing.Point(126, 82);
            this.appL.Name = "appL";
            this.appL.Size = new System.Drawing.Size(29, 13);
            this.appL.TabIndex = 0;
            this.appL.Text = "App:";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(126, 122);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(30, 13);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Név:";
            // 
            // pathL
            // 
            this.pathL.AutoSize = true;
            this.pathL.Location = new System.Drawing.Point(126, 163);
            this.pathL.Name = "pathL";
            this.pathL.Size = new System.Drawing.Size(79, 13);
            this.pathL.TabIndex = 2;
            this.pathL.Text = "Elérési útvonal:";
            // 
            // appBox
            // 
            this.appBox.FormattingEnabled = true;
            this.appBox.Location = new System.Drawing.Point(250, 82);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(195, 21);
            this.appBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(250, 122);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(195, 20);
            this.nameBox.TabIndex = 4;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(250, 163);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(195, 25);
            this.pathButton.TabIndex = 5;
            this.pathButton.Text = "Mappa kiválasztása";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(129, 209);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(316, 20);
            this.pathBox.TabIndex = 6;
            this.pathBox.Text = "Elérési útvonal...";
            // 
            // versionButton
            // 
            this.versionButton.Location = new System.Drawing.Point(203, 305);
            this.versionButton.Name = "versionButton";
            this.versionButton.Size = new System.Drawing.Size(180, 27);
            this.versionButton.TabIndex = 7;
            this.versionButton.Text = "Verzió kiválasztása";
            this.versionButton.UseVisualStyleBackColor = true;
            this.versionButton.Click += new System.EventHandler(this.versionButton_Click);
            // 
            // repoButton
            // 
            this.repoButton.Location = new System.Drawing.Point(129, 354);
            this.repoButton.Name = "repoButton";
            this.repoButton.Size = new System.Drawing.Size(316, 34);
            this.repoButton.TabIndex = 8;
            this.repoButton.Text = "Repozitórium létrehozása";
            this.repoButton.UseVisualStyleBackColor = true;
            this.repoButton.Click += new System.EventHandler(this.repoButton_Click);
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Location = new System.Drawing.Point(219, 271);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(81, 13);
            this.GitLabel.TabIndex = 9;
            this.GitLabel.Text = "Git inicializálása";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(334, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormRepositoryCreator
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.repoButton);
            this.Controls.Add(this.versionButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.appBox);
            this.Controls.Add(this.pathL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.appL);
            this.Name = "FormRepositoryCreator";
            this.Text = "Repository Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label pathL;
        private System.Windows.Forms.ComboBox appBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button versionButton;
        private System.Windows.Forms.Button repoButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.versionButton = new System.Windows.Forms.Button();
            this.repoButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elérési útvonal:";
            // 
            // appBox
            // 
            this.appBox.FormattingEnabled = true;
            this.appBox.Location = new System.Drawing.Point(268, 52);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(195, 21);
            this.appBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(268, 92);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(195, 20);
            this.nameBox.TabIndex = 4;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(268, 133);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(195, 25);
            this.pathButton.TabIndex = 5;
            this.pathButton.Text = "Gyökér mappa kiválasztása";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(147, 175);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(316, 20);
            this.pathBox.TabIndex = 6;
            this.pathBox.Text = "Elérési útvonal...";
            // 
            // versionButton
            // 
            this.versionButton.Location = new System.Drawing.Point(212, 268);
            this.versionButton.Name = "versionButton";
            this.versionButton.Size = new System.Drawing.Size(180, 27);
            this.versionButton.TabIndex = 7;
            this.versionButton.Text = "Verzió kiválasztása";
            this.versionButton.UseVisualStyleBackColor = true;
            // 
            // repoButton
            // 
            this.repoButton.Location = new System.Drawing.Point(147, 340);
            this.repoButton.Name = "repoButton";
            this.repoButton.Size = new System.Drawing.Size(316, 34);
            this.repoButton.TabIndex = 8;
            this.repoButton.Text = "Repozitórium létrehozása";
            this.repoButton.UseVisualStyleBackColor = true;
            // 
            // FormRepositoryCreator
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.repoButton);
            this.Controls.Add(this.versionButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.appBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRepositoryCreator";
            this.Text = "Repository Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox appBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button versionButton;
        private System.Windows.Forms.Button repoButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
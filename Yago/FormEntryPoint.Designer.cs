namespace Yago
{
    partial class FormEntryPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntryPoint));
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnVersions = new System.Windows.Forms.Button();
            this.btnRepoCreator = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.LightGray;
            this.pnlNavbar.Controls.Add(this.btnVersions);
            this.pnlNavbar.Controls.Add(this.btnRepoCreator);
            this.pnlNavbar.Controls.Add(this.btnTemplates);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(600, 48);
            this.pnlNavbar.TabIndex = 0;
            // 
            // btnVersions
            // 
            this.btnVersions.Location = new System.Drawing.Point(8, 8);
            this.btnVersions.Name = "btnVersions";
            this.btnVersions.Size = new System.Drawing.Size(96, 32);
            this.btnVersions.TabIndex = 0;
            this.btnVersions.Text = "Versions";
            this.btnVersions.UseVisualStyleBackColor = true;
            this.btnVersions.Click += new System.EventHandler(this.btnVersions_Click);
            // 
            // btnRepoCreator
            // 
            this.btnRepoCreator.Location = new System.Drawing.Point(110, 8);
            this.btnRepoCreator.Name = "btnRepoCreator";
            this.btnRepoCreator.Size = new System.Drawing.Size(140, 32);
            this.btnRepoCreator.TabIndex = 1;
            this.btnRepoCreator.Text = "Repository Creator";
            this.btnRepoCreator.UseVisualStyleBackColor = true;
            this.btnRepoCreator.Click += new System.EventHandler(this.btnRepoCreator_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(260, 8);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(96, 32);
            this.btnTemplates.TabIndex = 2;
            this.btnTemplates.Text = "Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 48);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 372);
            this.pnlContent.TabIndex = 1;
            // 
            // FormEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNavbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEntryPoint";
            this.Text = "YAGO Environmental Builder";
            this.Load += new System.EventHandler(this.FormEntryPoint_Load);
            this.pnlNavbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnVersions;
        private System.Windows.Forms.Button btnRepoCreator;
        private System.Windows.Forms.Button btnTemplates;
        private System.Windows.Forms.Panel pnlContent;
    }
}


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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavbar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlNavbar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(639, 59);
            this.pnlNavbar.TabIndex = 0;
            // 
            // btnVersions
            // 
            this.btnVersions.Location = new System.Drawing.Point(60, 12);
            this.btnVersions.Margin = new System.Windows.Forms.Padding(4);
            this.btnVersions.Name = "btnVersions";
            this.btnVersions.Size = new System.Drawing.Size(128, 39);
            this.btnVersions.TabIndex = 0;
            this.btnVersions.Text = "Versions";
            this.btnVersions.UseVisualStyleBackColor = true;
            this.btnVersions.Click += new System.EventHandler(this.btnVersions_Click);
            // 
            // btnRepoCreator
            // 
            this.btnRepoCreator.Location = new System.Drawing.Point(220, 12);
            this.btnRepoCreator.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepoCreator.Name = "btnRepoCreator";
            this.btnRepoCreator.Size = new System.Drawing.Size(187, 39);
            this.btnRepoCreator.TabIndex = 1;
            this.btnRepoCreator.Text = "Repository Creator";
            this.btnRepoCreator.UseVisualStyleBackColor = true;
            this.btnRepoCreator.Click += new System.EventHandler(this.btnRepoCreator_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(440, 12);
            this.btnTemplates.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(128, 39);
            this.btnTemplates.TabIndex = 2;
            this.btnTemplates.Text = "Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 59);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(639, 458);
            this.pnlContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Yago.Properties.Resources.YagoLogo3dNoBg;
            this.pictureBox1.Location = new System.Drawing.Point(60, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // FormEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 517);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNavbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEntryPoint";
            this.Text = "YAGO Environmental Builder";
            this.Load += new System.EventHandler(this.FormEntryPoint_Load);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnVersions;
        private System.Windows.Forms.Button btnRepoCreator;
        private System.Windows.Forms.Button btnTemplates;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


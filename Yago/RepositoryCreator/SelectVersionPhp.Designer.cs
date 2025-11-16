namespace Yago.RepositoryCreator
{
    partial class SelectVersionPhp
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
            this.phpL = new System.Windows.Forms.Label();
            this.ComposerL = new System.Windows.Forms.Label();
            this.phpBox = new System.Windows.Forms.ComboBox();
            this.composerBox = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phpL
            // 
            this.phpL.AutoSize = true;
            this.phpL.Location = new System.Drawing.Point(70, 40);
            this.phpL.Name = "phpL";
            this.phpL.Size = new System.Drawing.Size(29, 13);
            this.phpL.TabIndex = 0;
            this.phpL.Text = "Php:";
            // 
            // ComposerL
            // 
            this.ComposerL.AutoSize = true;
            this.ComposerL.Location = new System.Drawing.Point(70, 89);
            this.ComposerL.Name = "ComposerL";
            this.ComposerL.Size = new System.Drawing.Size(57, 13);
            this.ComposerL.TabIndex = 1;
            this.ComposerL.Text = "Composer:";
            // 
            // phpBox
            // 
            this.phpBox.FormattingEnabled = true;
            this.phpBox.Location = new System.Drawing.Point(161, 40);
            this.phpBox.Name = "phpBox";
            this.phpBox.Size = new System.Drawing.Size(121, 21);
            this.phpBox.TabIndex = 2;
            // 
            // composerBox
            // 
            this.composerBox.FormattingEnabled = true;
            this.composerBox.Location = new System.Drawing.Point(161, 89);
            this.composerBox.Name = "composerBox";
            this.composerBox.Size = new System.Drawing.Size(121, 21);
            this.composerBox.TabIndex = 3;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(137, 175);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // SelectVersionPhp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.composerBox);
            this.Controls.Add(this.phpBox);
            this.Controls.Add(this.ComposerL);
            this.Controls.Add(this.phpL);
            this.Name = "SelectVersionPhp";
            this.Text = "SelectVersionPhp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phpL;
        private System.Windows.Forms.Label ComposerL;
        private System.Windows.Forms.ComboBox phpBox;
        private System.Windows.Forms.ComboBox composerBox;
        private System.Windows.Forms.Button Ok;
    }
}
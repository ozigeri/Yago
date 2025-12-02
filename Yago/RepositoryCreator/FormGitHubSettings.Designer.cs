namespace Yago.RepositoryCreator
{
    partial class FormGitHubSettings
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(121, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(108, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Felhasználónév";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TokenLabel
            // 
            this.TokenLabel.Location = new System.Drawing.Point(124, 107);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(105, 20);
            this.TokenLabel.TabIndex = 1;
            this.TokenLabel.Text = "GitHub token ";
            this.TokenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(87, 72);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(177, 20);
            this.userBox.TabIndex = 2;
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(87, 136);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.PasswordChar = '*';
            this.tokenBox.Size = new System.Drawing.Size(177, 20);
            this.tokenBox.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormGitHubSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 271);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.TokenLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "FormGitHubSettings";
            this.Text = "FormGitHubSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace Yago.RepositoryCreator
{
    partial class SelectVersionNodeJS
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
            this.Ok = new System.Windows.Forms.Button();
            this.sVersionLabel = new System.Windows.Forms.Label();
            this.sVersionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(126, 138);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // sVersionLabel
            // 
            this.sVersionLabel.AutoSize = true;
            this.sVersionLabel.Location = new System.Drawing.Point(67, 61);
            this.sVersionLabel.Name = "sVersionLabel";
            this.sVersionLabel.Size = new System.Drawing.Size(36, 13);
            this.sVersionLabel.TabIndex = 1;
            this.sVersionLabel.Text = "Node:";
            // 
            // sVersionComboBox
            // 
            this.sVersionComboBox.FormattingEnabled = true;
            this.sVersionComboBox.Location = new System.Drawing.Point(138, 58);
            this.sVersionComboBox.Name = "sVersionComboBox";
            this.sVersionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sVersionComboBox.TabIndex = 2;
            // 
            // SelectVersionNodeJS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 209);
            this.Controls.Add(this.sVersionComboBox);
            this.Controls.Add(this.sVersionLabel);
            this.Controls.Add(this.Ok);
            this.Name = "SelectVersionNodeJS";
            this.Text = "SelectVersion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label sVersionLabel;
        private System.Windows.Forms.ComboBox sVersionComboBox;
    }
}
namespace Yago.Templates
{
    partial class EditTemplate
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
            this.lblName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.labelPhp = new System.Windows.Forms.Label();
            this.labelComposer = new System.Windows.Forms.Label();
            this.labelNode = new System.Windows.Forms.Label();
            this.comboPhp = new System.Windows.Forms.ComboBox();
            this.comboComposer = new System.Windows.Forms.ComboBox();
            this.comboNode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(169, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(169, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 13);
            this.lName.TabIndex = 1;
            // 
            // labelPhp
            // 
            this.labelPhp.AutoSize = true;
            this.labelPhp.Location = new System.Drawing.Point(71, 60);
            this.labelPhp.Name = "labelPhp";
            this.labelPhp.Size = new System.Drawing.Size(32, 13);
            this.labelPhp.TabIndex = 2;
            this.labelPhp.Text = "PHP:";
            // 
            // labelComposer
            // 
            this.labelComposer.AutoSize = true;
            this.labelComposer.Location = new System.Drawing.Point(71, 113);
            this.labelComposer.Name = "labelComposer";
            this.labelComposer.Size = new System.Drawing.Size(57, 13);
            this.labelComposer.TabIndex = 3;
            this.labelComposer.Text = "Composer:";
            // 
            // labelNode
            // 
            this.labelNode.AutoSize = true;
            this.labelNode.Location = new System.Drawing.Point(71, 173);
            this.labelNode.Name = "labelNode";
            this.labelNode.Size = new System.Drawing.Size(46, 13);
            this.labelNode.TabIndex = 4;
            this.labelNode.Text = "Node.js:";
            // 
            // comboPhp
            // 
            this.comboPhp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPhp.FormattingEnabled = true;
            this.comboPhp.Location = new System.Drawing.Point(237, 60);
            this.comboPhp.Name = "comboPhp";
            this.comboPhp.Size = new System.Drawing.Size(121, 21);
            this.comboPhp.TabIndex = 5;
            // 
            // comboComposer
            // 
            this.comboComposer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboComposer.FormattingEnabled = true;
            this.comboComposer.Location = new System.Drawing.Point(237, 110);
            this.comboComposer.Name = "comboComposer";
            this.comboComposer.Size = new System.Drawing.Size(121, 21);
            this.comboComposer.TabIndex = 6;
            // 
            // comboNode
            // 
            this.comboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNode.FormattingEnabled = true;
            this.comboNode.Location = new System.Drawing.Point(237, 170);
            this.comboNode.Name = "comboNode";
            this.comboNode.Size = new System.Drawing.Size(121, 21);
            this.comboNode.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(410, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboNode);
            this.Controls.Add(this.comboComposer);
            this.Controls.Add(this.comboPhp);
            this.Controls.Add(this.labelNode);
            this.Controls.Add(this.labelComposer);
            this.Controls.Add(this.labelPhp);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lblName);
            this.Name = "EditTemplate";
            this.Text = "EditTemplate";
            this.Load += new System.EventHandler(this.EditTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label labelPhp;
        private System.Windows.Forms.Label labelComposer;
        private System.Windows.Forms.Label labelNode;
        private System.Windows.Forms.ComboBox comboPhp;
        private System.Windows.Forms.ComboBox comboComposer;
        private System.Windows.Forms.ComboBox comboNode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
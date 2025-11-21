namespace Yago.Templates
{
    partial class FormTemplates
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
            this.dataGridTemplates = new System.Windows.Forms.DataGridView();
            this.btnTemplateDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTemplates
            // 
            this.dataGridTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTemplates.Location = new System.Drawing.Point(60, 82);
            this.dataGridTemplates.Name = "dataGridTemplates";
            this.dataGridTemplates.Size = new System.Drawing.Size(528, 150);
            this.dataGridTemplates.TabIndex = 0;
            this.dataGridTemplates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTemplates_CellContentClick);
            // 
            // btnTemplateDelete
            // 
            this.btnTemplateDelete.Location = new System.Drawing.Point(262, 273);
            this.btnTemplateDelete.Name = "btnTemplateDelete";
            this.btnTemplateDelete.Size = new System.Drawing.Size(157, 49);
            this.btnTemplateDelete.TabIndex = 1;
            this.btnTemplateDelete.Text = "Template törlése";
            this.btnTemplateDelete.UseVisualStyleBackColor = true;
            this.btnTemplateDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormTemplates
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnTemplateDelete);
            this.Controls.Add(this.dataGridTemplates);
            this.Name = "FormTemplates";
            this.Text = "Templates";
            this.Load += new System.EventHandler(this.TemplatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTemplates;
        private System.Windows.Forms.Button btnTemplateDelete;
    }
}
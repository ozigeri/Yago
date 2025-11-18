using EnviromentBuilder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yago.Versions;

namespace Yago.Templates
{
    public partial class FormTemplates : Form
    {
        public FormTemplates()
        {
            InitializeComponent();
            
        }

        private void TemplatesForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadTemplateNamesToGrid();
        }

        private void SetupGrid()
        {
            dataGridTemplates.Columns.Clear();

            var colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.HeaderText = "Sablon neve";
            colName.ReadOnly = true;
            dataGridTemplates.Columns.Add(colName);

            var colEdit = new DataGridViewButtonColumn();
            colEdit.Name = "Edit";
            colEdit.HeaderText = "Sablon szerkesztése";
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            dataGridTemplates.Columns.Add(colEdit);

            var colSelect = new DataGridViewCheckBoxColumn();
            colSelect.Name = "Select";
            colSelect.HeaderText = "Sablon törlése";
            dataGridTemplates.Columns.Add(colSelect);

            dataGridTemplates.AllowUserToAddRows = false;
            dataGridTemplates.RowHeadersVisible = false;
            dataGridTemplates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTemplateNamesToGrid()
        {
            MessageBox.Show("Betöltött sablonok száma: " + TemplateManager.GetTemplateNames().Count);

            dataGridTemplates.Rows.Clear();

            var names = TemplateManager.GetTemplateNames();

            foreach (var name in names)
            {
                dataGridTemplates.Rows.Add(name, "Edit", false);
            }
        }
    }
}

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
using Yago.Templates.Methods;
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

        private void dataGridTemplates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

            
            if (dataGridTemplates.Columns[e.ColumnIndex].Name == "Edit")
            {
                string templateName = dataGridTemplates.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                
                EditTemplateButton(templateName);
            }
        }

        private void EditTemplateButton(string templateName)
        {
            EditTemplate editForm = new EditTemplate(templateName);
            editForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> itemsToDelete = new List<string>();

            foreach (DataGridViewRow row in dataGridTemplates.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value);
                if (isChecked)
                {
                    string templateName = row.Cells["Name"].Value.ToString();
                    itemsToDelete.Add(templateName);
                }
            }

            if (itemsToDelete.Count == 0)
            {
                MessageBox.Show("Nincs kijelölt sablon!", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show(
                $"{itemsToDelete.Count} sablon törlése.\nBiztosan törölni szeretnéd?",
                "Megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return; 


            TemplateMethods.DeleteTemplates(itemsToDelete);


            for (int i = dataGridTemplates.Rows.Count - 1; i >= 0; i--)
            {
                bool isChecked = Convert.ToBoolean(dataGridTemplates.Rows[i].Cells["Select"].Value);
                if (isChecked)
                    dataGridTemplates.Rows.RemoveAt(i);
            }

            MessageBox.Show("A kijelölt sablonok törölve lettek.",
                "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

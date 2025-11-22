using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Yago.Versions.Core
{
    public static class TemplateManager
    {
        private static readonly string TemplateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templates.txt");

        static TemplateManager()
        {
            if (!File.Exists(TemplateFile))
            {
                File.Create(TemplateFile).Close();
            }
        }

        public static void SaveTemplate(string name, string php, string composer, string node)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Kérlek adj meg egy sablon nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(TemplateFile);
            bool exists = lines.Any(line => line.StartsWith(name + ";", StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                MessageBox.Show($"Már létezik '{name}' nevű sablon!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTemplate = $"{name};{php};{composer};{node}";
            File.AppendAllLines(TemplateFile, new[] { newTemplate });

            MessageBox.Show($"Sablon '{name}' sikeresen elmentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<string> GetTemplateNames()
        {
            if (!File.Exists(TemplateFile))
            {
                return new List<string>();
            }

            return File.ReadAllLines(TemplateFile)
                       .Where(line => line.Contains(";"))
                       .Select(line => line.Split(';')[0])
                       .ToList();
        }

        public static (string php, string composer, string node)? LoadTemplate(string name)
        {
            if (!File.Exists(TemplateFile))
            {
                return null;
            }

            string line = File.ReadAllLines(TemplateFile)
                           .FirstOrDefault(l => l.StartsWith(name + ";", StringComparison.OrdinalIgnoreCase));

            if (line == null)
            {
                return null;
            }

            string[] parts = line.Split(';');
            if (parts.Length < 4)
            {
                return null;
            }

            return (parts[1], parts[2], parts[3]);
        }

        public static void InitializeTemplateComboBox(ComboBox combo)
        {
            combo.Items.Clear();

            List<string> templates = GetTemplateNames();
            foreach (string name in templates)
            {
                combo.Items.Add(name);
            }

            combo.SelectedIndex = -1;
        }
    }
}

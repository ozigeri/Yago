using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yago.Templates.Methods
{
    public class TemplateMethods
    {
        public static string TemplateFile = Path.Combine(Application.StartupPath, "Templates.txt");

        public static Dictionary<string, TemplateItem> LoadTemplates()
        {
            var templates = new Dictionary<string, TemplateItem>();

            foreach (var line in File.ReadAllLines(TemplateFile))
            {
                if (!line.Contains(";")) continue;

                var parts = line.Split(';');

                var item = new TemplateItem
                {
                    Name = parts[0],
                    Php = parts[1],
                    Composer = parts[2],
                    Node = parts[3]
                };

                templates[item.Name] = item;
            }

            return templates;
        }

        public static TemplateItem GetTemplateByName(string name)
        {
            var all = LoadTemplates();
            return all.ContainsKey(name) ? all[name] : null;
        }

        public static void SaveTemplate(TemplateItem item)
        {
            var all = LoadTemplates();

            
            all[item.Name] = item;

            
            using (StreamWriter sw = new StreamWriter(TemplateFile, false))
            {
                foreach (var t in all.Values)
                {
                    sw.WriteLine($"{t.Name};{t.Php};{t.Composer};{t.Node}");
                }
            }
        }

        public static void LoadVersionsFromDirectory(string path, ComboBox combo)
        {
            combo.Items.Clear();

            if (!Directory.Exists(path))
                return;

            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                string folderName = Path.GetFileName(dir);

                string version = Regex.Replace(folderName, @"[^\d\.]", "");

                if (!string.IsNullOrWhiteSpace(version))
                {
                    combo.Items.Add(version);
                }
            }


            combo.SelectedIndex = -1;
        }

        public static void DeleteTemplates(List<string> names)
        {
            var all = LoadTemplates();

            
            foreach (string name in names)
            {
                if (all.ContainsKey(name))
                    all.Remove(name);
            }

            
            using (StreamWriter sw = new StreamWriter(TemplateFile, false))
            {
                foreach (var t in all.Values)
                {
                    sw.WriteLine($"{t.Name};{t.Php};{t.Composer};{t.Node}");
                }
            }
        }
    }
}

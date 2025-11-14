using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yago.Templates.TemplateModel
{
    public class TemplateModel
    {
        public string Name { get; set; }
        public string Php { get; set; }
        public string Composer { get; set; }
        public string Node { get; set; }

        public TemplateModel(string name, string php, string composer, string node)
        {
            Name = name;
            Php = php;
            Composer = composer;
            Node = node;
        }
    }
}

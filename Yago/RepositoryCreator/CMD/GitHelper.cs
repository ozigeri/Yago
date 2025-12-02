using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yago.RepositoryCreator.CMD
{
    public static class GitHelper
    {
        public static void GitInit(StringBuilder sb)
        {
            sb.AppendLine("echo.");
            sb.AppendLine("echo GIT INICIALIZALASA");
            sb.AppendLine("git --version >nul 2>&1");
            sb.AppendLine("if %errorlevel% neq 0 (");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo.");
            sb.AppendLine("\techo Hiba: A Git nincs telepítve vagy nincs a PATH-ban.");
            sb.AppendLine("\techo A repository inicializalasa sikertelen.");
            sb.AppendLine("\techo.");
            sb.AppendLine(") else (");
            sb.AppendLine("\tgit init");
            sb.AppendLine("\tgit add .");
            sb.AppendLine("\tgit commit -m \"Initial commit: Yago\"");
            sb.AppendLine("\techo.");
            sb.AppendLine("\techo Git repository letrehozva!");
            sb.AppendLine("color 0A");
            sb.AppendLine(")");
        }
    }
}

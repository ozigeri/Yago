using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yago.RepositoryCreator.RCEnums;

namespace Yago.RepositoryCreator.CMD
{
    public static class CMDHelper
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

        public static void CheckAndCleanDir(StringBuilder sb, string name)
        {
            sb.AppendLine($"if not exist \"{name}\" goto :START_INSTALL");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo.");
            sb.AppendLine($"\techo !!!!!!!!! HIBA: A(Z) {name} MAPPA MAR LETEZIK !!!!!!!!!");
            sb.AppendLine("\techo Szeretned TOROLNI a meglevo mappat A TELJES TARTALMAVAL es folytatni a telepitest?");
            sb.AppendLine("\techo.");

            sb.AppendLine("set /p user_answer=Nyomj 'I' betut a torleshez, vagy Entert a kilepeshez: ");
            sb.AppendLine("if /i \"%user_answer%\" neq \"I\" (");
            sb.AppendLine("\techo A telepites megszakitva.");
            sb.AppendLine("\tpause");
            sb.AppendLine("\texit");
            sb.AppendLine(")");

            sb.AppendLine("echo.");
            sb.AppendLine($"echo Mappa torlese: {name}...");
            sb.AppendLine($"rd /s /q \"{name}\"");
            sb.AppendLine("color 07");
            sb.AppendLine("cls");
        }

        public static void openInEditor(StringBuilder sb, string editorName)
        {
            if (!Enum.TryParse(editorName,out EditorTypes editor))
            {
                return;
            }

            if (editor == EditorTypes.None) return;

            sb.AppendLine("echo.");
            sb.AppendLine($"echo Megnyitas a kovetkezoben: {editorName}");

            switch (editor)
            {
                case EditorTypes.VSCode:
                    sb.AppendLine("powershell -Command \"Start-Process code .\"");
                    break;
                case EditorTypes.PhpStorm:
                    sb.AppendLine("powershell -Command \"Start-Process phpstorm .\"");
                    break;
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yago.Versions.Core;

namespace Yago.RepositoryCreator.CMD
{
    internal class NodeCMDCommand
    {
        string app { get; set; }
        string name { get; set; }
        string location { get; set; }
        string version { get; set; }
        public NodeCMDCommand(string app, string name, string location, string version)
        {
            this.app = app;
            this.name = name;
            this.location = location;
            this.version = version;
        }
        public void Execute(bool opensBrowser)
        {
            string tempBatPath = Path.Combine(Path.GetTempPath(), "node_temp_start.bat");
            string nodeDir = Path.Combine(EnvironmentManager.BasePaths[Versions.Enums.VersionType.NodeJs], $"v{version}");

            string BatchContent = GenerateBatchScript(nodeDir, opensBrowser);

            RunBatchFile(tempBatPath, BatchContent);

        }

        private string GenerateBatchScript(string nodeDir, bool opensBrowser)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            sb.AppendLine($"cd /d \"{location}\"");

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

            sb.AppendLine(":START_INSTALL");
            sb.AppendLine($"set \"NODE_HOME={nodeDir}\"");
            sb.AppendLine("set \"PATH=%NODE_HOME%;%PATH%\"");
            sb.AppendLine("echo.");
            sb.AppendLine("echo Vite projekt letrehozasa...");
            sb.AppendLine($"echo No | call npm create vite@latest \"{name}\" -- --template {app.ToLower()}");

            sb.AppendLine("if %errorlevel% neq 0 (");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo.");
            sb.AppendLine("\techo !!!!!!!!! HIBA: NEM SIKERULT LETREHOZNI A PROJEKTET !!!!!!!!!");
            sb.AppendLine("\tpause");
            sb.AppendLine("\texit");
            sb.AppendLine(")");

            sb.AppendLine($"cd \"{name}\"");
            sb.AppendLine("echo.");
            sb.AppendLine("echo Fuggosegek telepitese (npm install)...");
            sb.AppendLine("call npm install");

            sb.AppendLine("if %errorlevel% neq 0 (");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo.");
            sb.AppendLine("\techo !!!!!!!!! HIBA: A FUGGOSEGEK TELEPITESE SIKERTELEN !!!!!!!!!");
            sb.AppendLine("\tpause");
            sb.AppendLine("\texit");
            sb.AppendLine(")");

            sb.AppendLine("cls");
            sb.AppendLine("color 0A");
            sb.AppendLine("echo.");
            sb.AppendLine("echo Sikeres telepites!");
            sb.AppendLine($"echo A projekt elkeszult a(z) {name} mappaban.");

            string npmRunDev = "npm run dev";
            if (opensBrowser) npmRunDev += " -- --open";
            sb.AppendLine($"start \"Vite Dev Server\" cmd /k \"{npmRunDev}\"");

            sb.AppendLine("timeout /t 5 /nobreak >nul");
            sb.AppendLine("exit");
            return sb.ToString();
        }

        private void RunBatchFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content, Encoding.Default);

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k \"{filePath}\"",
                    UseShellExecute = true,
                    CreateNoWindow = false
                }
            };

            process.Start();
        }
    }
}

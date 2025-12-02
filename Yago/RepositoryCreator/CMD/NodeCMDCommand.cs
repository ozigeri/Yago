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
        public void Execute(bool opensBrowser, bool GitInit, bool isTypeScript, string selectedEditor)
        {
            string tempBatPath = Path.Combine(Path.GetTempPath(), "node_temp_start.bat");
            string nodeDir = Path.Combine(EnvironmentManager.BasePaths[Versions.Enums.VersionType.NodeJs], $"v{version}");

            string BatchContent = GenerateBatchScript(nodeDir, opensBrowser, GitInit, isTypeScript, selectedEditor);

            RunBatchFile(tempBatPath, BatchContent);

        }

        private string GenerateBatchScript(string nodeDir, bool opensBrowser, bool GitInit, bool isTypeScript, string selectedEditor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            sb.AppendLine($"cd /d \"{location}\"");
            CMDHelper.CheckAndCleanDir(sb, name);
            sb.AppendLine(":START_INSTALL");
            sb.AppendLine($"set \"NODE_HOME={nodeDir}\"");
            sb.AppendLine("set \"PATH=%NODE_HOME%;%PATH%\"");
            sb.AppendLine("echo.");
            sb.AppendLine("echo Vite projekt letrehozasa...");

            string templateName = app.ToLower();
            if (isTypeScript) templateName += "-ts";

            sb.AppendLine($"echo No | call npm create vite@latest \"{name}\" -- --template {templateName}");

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

            if (GitInit)
            {
                GitHelper.GitInit(sb);
                GitHelper.SetupRemoteAndPush(sb, name);
            }
            CMDHelper.openInEditor(sb, selectedEditor);
            
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
                    Arguments = $"/c \"{filePath}\"",
                    UseShellExecute = true,
                    CreateNoWindow = false
                }
            };

            process.Start();
        }
    }
}

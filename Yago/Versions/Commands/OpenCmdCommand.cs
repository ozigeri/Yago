using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EnviromentBuilder.Core.Commands
{
    public class OpenCmdCommand
    {
        private readonly string phpPath;
        private readonly string composerPath;
        private readonly string nodePath;

        public OpenCmdCommand(string phpPath, string composerPath, string nodePath)
        {
            this.phpPath = phpPath;
            this.composerPath = composerPath;
            this.nodePath = nodePath;
        }

        public void Execute()
        {
            string tempBatPath = Path.Combine(Path.GetTempPath(), "env_temp_start.bat");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            sb.AppendLine($"set \"PHP_HOME={phpPath}\"");
            sb.AppendLine($"set \"COMPOSER_HOME={composerPath}\"");
            sb.AppendLine($"set \"NODE_HOME={nodePath}\"");
            sb.AppendLine("set \"PATH=%PHP_HOME%;%COMPOSER_HOME%;%NODE_HOME%;%PATH%\"");
            sb.AppendLine("echo Environment variables set!");
            sb.AppendLine("echo -------------------------------------");
            sb.AppendLine("php.exe %COMPOSER_HOME%\\composer.phar -V");
            sb.AppendLine("node -v");
            sb.AppendLine("echo -------------------------------------");
            sb.AppendLine("cmd /k");

            File.WriteAllText(tempBatPath, sb.ToString(), Encoding.Default);

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k \"{tempBatPath}\"",
                    UseShellExecute = true,
                    CreateNoWindow = false
                }
            };

            process.Start();
        }
    }
}

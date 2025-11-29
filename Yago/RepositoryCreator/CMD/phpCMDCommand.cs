using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yago.Versions.Controllers;
using Yago.Versions.Core;
using Yago.Versions.Enums;

namespace Yago.RepositoryCreator.CMD
{
    internal class phpCMDCommand
    {
        string app { get; set; }
        string name { get; set; }
        string location { get; set; }
        string php { get; set; }
        string composer { get; set; }
        public phpCMDCommand(string app, string name, string location, string php, string composer)
        {
            this.app = app;
            this.name = name;
            this.location = location;
            this.php = php;
            this.composer = composer;
        }

        public void Execute(bool GitInit, string selectedEditor)
        {
            string tempBatPath = Path.Combine(Path.GetTempPath(), "php_temp_start.bat");
            string phpPath = EnvironmentManager.BasePaths[VersionType.Php] + '\\' + "php" + php + '\\';

            SetupPhpConfig(phpPath);

            string phpExe = $"\"{phpPath}php.exe\"";
            string phpIni = $"\"{phpPath}php.ini\"";
            string composerPhar = $"\"{Path.Combine(EnvironmentManager.BasePaths[VersionType.Composer], "v" + composer, "composer.phar")}\"";

            string batchContent = GenerateBatchScript(phpExe, phpIni, composerPhar, phpPath, GitInit, selectedEditor);

            RunBatchFile(tempBatPath, batchContent);
        }

        private void SetupPhpConfig(string phpPath)
        {
            string iniFile = Path.Combine(phpPath, "php.ini");
            string iniTemplate = Path.Combine(phpPath, "php.ini-development");

            if (!File.Exists(iniFile))
            {
                if (File.Exists(iniTemplate))
                {
                    File.Copy(iniTemplate, iniFile);
                }
                else
                {
                    return;
                }
            }

            string content = File.ReadAllText(iniFile);

            content = content.Replace(";extension_dir = \"ext\"", "extension_dir = \"ext\"");
            content = content.Replace(";extension=openssl", "extension=openssl");
            content = content.Replace(";extension=zip", "extension=zip");
            content = content.Replace(";extension=fileinfo", "extension=fileinfo");
            content = content.Replace(";extension=mbstring", "extension=mbstring");
            content = content.Replace(";extension=curl", "extension=curl");
            content = content.Replace(";extension=pdo_sqlite", "extension=pdo_sqlite");
            content = content.Replace(";extension=sqlite3", "extension=sqlite3");
            content = content.Replace(";extension=pdo_mysql", "extension=pdo_mysql");
            content = content.Replace(";extension=mysqli", "extension=mysqli");
            content = content.Replace("error_reporting = E_ALL", "error_reporting = E_ALL & ~E_DEPRECATED & ~E_STRICT");
            File.WriteAllText(iniFile, content);
        }

        private string GenerateBatchScript(string phpExe, string phpIni, string composerPhar, string phpPath, bool GitInit, string selectedEditor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            sb.AppendLine($"cd /d \"{location}\"");
            CMDHelper.CheckAndCleanDir(sb, name);

            sb.AppendLine(":START_INSTALL");
            sb.AppendLine("set PHPRC=");
            sb.AppendLine("set PHP_INI_SCAN_DIR=");
            sb.AppendLine($"set \"PATH={phpPath};%PATH%\"");
            sb.AppendLine($"{phpExe} -c {phpIni} {composerPhar} create-project laravel/laravel {name}");

            sb.AppendLine("if %errorlevel% neq 0 (");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo.");
            sb.AppendLine("\techo !!!!!!!!!!! HIBA TORTENT A TELEPITES SORAN !!!!!!!!!!!");
            sb.AppendLine("\tpause");
            sb.AppendLine("\texit");
            sb.AppendLine(")");

            sb.AppendLine($"cd \"{name}\"");
            sb.AppendLine("cls");
            sb.AppendLine("color 0A");
            sb.AppendLine("echo.");
            sb.AppendLine($"echo A project elkeszult a(z) {name} mappaban.");
            if (GitInit) CMDHelper.GitInit(sb);
            CMDHelper.openInEditor(sb, selectedEditor);

            sb.AppendLine("echo.");
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
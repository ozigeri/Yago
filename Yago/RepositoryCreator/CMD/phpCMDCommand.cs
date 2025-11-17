using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Execute()
        {
            string tempBatPath = Path.Combine(Path.GetTempPath(), "php_temp_start.bat");

            string composerPath = @"C:\composer\composer.bat";
            string phpPath = @"C:\xampp\php";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("@echo off");
            sb.AppendLine($"cd {location}");
            sb.AppendLine($"set \"PATH={phpPath};%PATH%\"");
            sb.AppendLine($"call \"{composerPath}\" create-project laravel/laravel {name}");
            sb.AppendLine($"cd {name}");
            sb.AppendLine("cls");
            sb.AppendLine("echo Repository letrehozva!");
            sb.AppendLine("timeout /t 5 /nobreak >nul");
            sb.AppendLine("exit");


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
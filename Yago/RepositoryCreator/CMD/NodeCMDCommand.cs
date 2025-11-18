using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("@echo off");
            sb.AppendLine($"cd {location}");
            sb.AppendLine($"set \"NODE_HOME=C:\\nodejs\\v{version}\"");
            sb.AppendLine("set \"PATH=%NODE_HOME%;%PATH%\"");
            sb.AppendLine($"echo No | npm create vite@latest {name} -- --template {app.ToLower()}\"");
            sb.AppendLine($"cd {name}");
            sb.AppendLine("call npm install");
            sb.AppendLine("echo Repo created!");
            if (opensBrowser) sb.AppendLine("start http://localhost:5173");
            sb.AppendLine("start cmd /k \"npm run dev\"");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

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

        public static void SetupRemoteAndPush (StringBuilder sb, string repoName)
        {
            string user = Properties.Settings.Default.GitHubUsername;
            string token = Properties.Settings.Default.GitHubToken;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Kérlek töltsd ki a Git Authot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sb.AppendLine("echo.");
            sb.AppendLine("Echo GitHub tavoli repozitorium beallitasa es feltoltese...");

            string remoteUrl = $"https://{user}:{token}@github.com/{user}/{repoName}.git";

            sb.AppendLine($"git remote add origin {remoteUrl}");
            sb.AppendLine("git branch -M main");
            sb.AppendLine("git -c credential.helper= push -u origin main >nul 2>&1");

            sb.AppendLine("if %errorlevel% equ 0 (");
            sb.AppendLine("color 0A");
            sb.AppendLine("\techo SIKERES FELTOLTES A GITHUBRA!");
            sb.AppendLine(") else (");
            sb.AppendLine("\tcolor 0C");
            sb.AppendLine("\techo HIBA: NEM SIKERULT A FELTOLTES!");
            sb.AppendLine("\techo Ellenorizd a tokent, vagy hogy letezik-e a repo a GitHubon!");
            sb.AppendLine(")");

        }

        public static async Task<bool> CreateGithubRepo(string repoName)
        {
            try
            {
                string token = Properties.Settings.Default.GitHubToken;

                if (string.IsNullOrWhiteSpace(token))
                {
                    MessageBox.Show("A GitHub repository létrehozásához szükség van a Tokenre!\nKérlek állítsd be a Beállításokban.",
                                    "Hiányzó Token", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var client = new GitHubClient(new ProductHeaderValue("Yago-App"));
                var tokenAuth = new Credentials(token);
                client.Credentials = tokenAuth;

                var newRepo = new NewRepository(repoName)
                {
                    Private = true,
                    AutoInit = false

                };

                await client.Repository.Create(newRepo);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nem sikerült létrehozni a GitHub repót:\n{ex.Message}",
                                "GitHub API Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

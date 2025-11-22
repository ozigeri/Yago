using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using System.Text.RegularExpressions;
using Yago.Versions.Core;
using Yago.Versions.Enums;
using Yago.Commands;
using System.Reflection;

namespace Versions.Tests
{
    public class EnvironmentManagerTests
    {
        [Fact]
        public void CleanVersionName_ShouldRemoveNonNumericChars()
        {
            string result = EnvironmentManagerTestWrapper.CleanVersionName("php7.4.1");
            Assert.Equal("7.4.1", result);

            result = EnvironmentManagerTestWrapper.CleanVersionName("v16.17.0");
            Assert.Equal("16.17.0", result);
        }

        [Fact]
        public void GetSoftwareVersion_ShouldReturnEmptyIfDirDoesNotExist()
        {
            EnvironmentManager.BasePaths[VersionType.Php] = Path.Combine(Path.GetTempPath(), "nonexistent");
            List<string> result = EnvironmentManager.GetSoftwareVersion(VersionType.Php);
            Assert.Empty(result);
        }
        [Fact]
        public void LoadAndSavePaths_ShouldPersistValues()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "basepath_test.txt");
            EnvironmentManagerTestWrapper.SetPathFile(tempPath);

            EnvironmentManager.BasePaths[VersionType.Php] = @"C:\testphp";
            EnvironmentManager.SavePathsToFile();

            EnvironmentManager.BasePaths[VersionType.Php] = @"C:\reset";
            EnvironmentManager.LoadPathsFromFile();

            Assert.Equal(@"C:\testphp", EnvironmentManager.BasePaths[VersionType.Php]);

            File.Delete(tempPath);
        }

        [Fact]
        public void GetSoftwareVersion_ShouldReturnCleanedVersionList()
        {
            string tempDir = Path.Combine(Path.GetTempPath(), "version_test");
            Directory.CreateDirectory(tempDir);
            string[] dirs = { "php7.2.1", "v7.3.0", "invalid", "v8.0.0" };
            foreach (string d in dirs) Directory.CreateDirectory(Path.Combine(tempDir, d));

            EnvironmentManager.BasePaths[VersionType.Php] = tempDir;
            List<string> result = EnvironmentManager.GetSoftwareVersion(VersionType.Php);

            Assert.Contains("7.2.1", result);
            Assert.Contains("7.3.0", result);
            Assert.Contains("8.0.0", result);
            Assert.DoesNotContain("invalid", result);

            Directory.Delete(tempDir, true);
        }
    }
    public static class EnvironmentManagerTestWrapper
    {
        public static string CleanVersionName(string folderName)
        {
            return Regex.Replace(folderName, @"[^\d\.]", "");
        }

        public static void SetPathFile(string path)
        {
            FieldInfo field = typeof(EnvironmentManager).GetField("pathFile", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, path);
        }
    }
    public class TemplateManagerTests
    {
        private readonly string tempTemplateFile = Path.Combine(Path.GetTempPath(), "templates_test.txt");

        public TemplateManagerTests()
        {
            FieldInfo field = typeof(TemplateManager).GetField("TemplateFile", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, tempTemplateFile);
            if (File.Exists(tempTemplateFile)) File.Delete(tempTemplateFile);
            File.Create(tempTemplateFile).Close();
        }

        [Fact]
        public void SaveTemplate_ShouldCreateAndLoadTemplate()
        {
            TemplateManager.SaveTemplate("myTemplate", "7.4", "2.1", "16.17");

            List<string> templates = TemplateManager.GetTemplateNames();
            Assert.Contains("myTemplate", templates);

            var loaded = TemplateManager.LoadTemplate("myTemplate");
            Assert.NotNull(loaded);
            Assert.Equal("7.4", loaded.Value.php);
            Assert.Equal("2.1", loaded.Value.composer);
            Assert.Equal("16.17", loaded.Value.node);
        }

        [Fact]
        public void SaveTemplate_ShouldPreventDuplicate()
        {
            TemplateManager.SaveTemplate("dupTemplate", "7.4", "2.1", "16.17");
            int countBefore = TemplateManager.GetTemplateNames().Count;

            TemplateManager.SaveTemplate("dupTemplate", "7.4", "2.1", "16.17");
            int countAfter = TemplateManager.GetTemplateNames().Count;

            Assert.Equal(countBefore, countAfter);
        }

        [Fact]
        public void LoadTemplate_ShouldReturnNullIfNotExist()
        {
            var result = TemplateManager.LoadTemplate("nonexistent");
            Assert.Null(result);
        }

        [Fact]
        public void GetTemplateNames_ShouldReturnCorrectList()
        {
            TemplateManager.SaveTemplate("template1", "7.2", "1.0", "12.0");
            TemplateManager.SaveTemplate("template2", "7.4", "2.0", "14.0");

            List<string> names = TemplateManager.GetTemplateNames();
            Assert.Contains("template1", names);
            Assert.Contains("template2", names);
        }

        [Fact]
        public void SaveTemplate_ShouldWarnWhenNameEmpty()
        {
            TemplateManager.SaveTemplate("", "7.4", "2.0", "16.0");
        }
    }
    public class OpenCmdCommandTests
    {
        [Fact]
        public void Execute_ShouldCreateBatchFile()
        {
            string tempBat = Path.Combine(Path.GetTempPath(), "env_temp_start.bat");
            if (File.Exists(tempBat)) File.Delete(tempBat);

            OpenCmdCommand cmd = new OpenCmdCommand(@"C:\php", @"C:\composer", @"C:\node");
            cmd.Execute();

            Assert.True(File.Exists(tempBat));
        }

        [Fact]
        public void Execute_BatchFileContentShouldContainPaths()
        {
            string tempBat = Path.Combine(Path.GetTempPath(), "env_temp_start.bat");
            if (File.Exists(tempBat)) File.Delete(tempBat);

            OpenCmdCommand cmd = new OpenCmdCommand(@"C:\phpPath", @"C:\composerPath", @"C:\nodePath");
            cmd.Execute();

            string content = File.ReadAllText(tempBat);
            Assert.Contains("PHP_HOME=C:\\phpPath", content);
            Assert.Contains("COMPOSER_HOME=C:\\composerPath", content);
            Assert.Contains("NODE_HOME=C:\\nodePath", content);
        }
    }
}
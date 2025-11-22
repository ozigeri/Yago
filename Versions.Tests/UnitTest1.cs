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
}
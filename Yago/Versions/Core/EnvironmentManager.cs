using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Yago.Versions.Enums;

namespace Yago.Versions.Core
{
    public static class EnvironmentManager
    {
        public static readonly Dictionary<VersionType, string> BasePaths = new Dictionary<VersionType, string>
        {
            { VersionType.Php, @"C:\php" },
            { VersionType.Composer, @"C:\composer" },
            { VersionType.NodeJs, @"C:\nodejs" }
        };

        private static string CleanVersionName(string folderName)
        {
            // pl.: "php7.2.9" -> "7.2.9"
            // pl.: "v16.17.0" -> "16.17.0"
            return Regex.Replace(folderName, @"[^\d\.]", "");
        }

        public static List<string> GetSoftwareVersion(VersionType software)
        {

            string path = BasePaths[software];

            if (!Directory.Exists(path)) return new List<string>();

            return Directory.GetDirectories(path)
                            .Select(Path.GetFileName)
                            .Select(CleanVersionName)
                            .Where(version => !string.IsNullOrWhiteSpace(version))
                            .ToList();
        }
    }
}

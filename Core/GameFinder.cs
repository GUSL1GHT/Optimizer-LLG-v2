
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class GameFinder
    {
        private static readonly string[] CommonPaths = new string[]
        {
            "C:\\Program Files",
            "C:\\Program Files (x86)",
            "C:\\Games",
            "D:\\Games",
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        };

        public static string FindExecutable(string gameName)
        {
            foreach (var basePath in CommonPaths)
            {
                try
                {
                    var matches = Directory.GetFiles(basePath, "*.exe", SearchOption.AllDirectories);
                    foreach (var path in matches)
                    {
                        if (Path.GetFileNameWithoutExtension(path).ToLower().Contains(gameName.ToLower()))
                            return path;
                    }
                }
                catch { }
            }
            return null;
        }

        public static Process LaunchGame(string exePath)
        {
            return Process.Start(new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = true
            });
        }
    }
}
using System;
using System.Diagnostics;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class WindowsConfigurator
    {
        public static void Apply()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "config.bat");
            if (File.Exists(path))
                Process.Start(new ProcessStartInfo("cmd.exe", "/c " + path) { CreateNoWindow = true });
        }
    }
}
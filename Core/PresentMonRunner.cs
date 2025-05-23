using System;
using System.Diagnostics;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class PresentMonRunner
    {
        public static void StartCapture(string processName, int seconds)
        {
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "PresentMon.exe");
            string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output", "presentmon.csv");
            string args = $"-process-name {processName} -output \"{outputPath}\" -timed {seconds}";

            var psi = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = args,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process.Start(psi);
        }
    }
}
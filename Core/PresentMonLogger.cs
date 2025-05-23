
using System;
using System.Diagnostics;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class PresentMonLogger
    {
        private static Process _process;
        private static string _outputFile;

        public static void Start(string outputFile)
        {
            _outputFile = outputFile;
            string presentMonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "PresentMon.exe");

            if (!File.Exists(presentMonPath))
                throw new FileNotFoundException("PresentMon.exe no encontrado en la ruta esperada.", presentMonPath);

            _process = new Process();
            _process.StartInfo.FileName = presentMonPath;
            _process.StartInfo.Arguments = $"-captureall -output_file \"{_outputFile}\" -no_top";
            _process.StartInfo.UseShellExecute = false;
            _process.StartInfo.CreateNoWindow = true;
            _process.Start();
        }

        public static void Stop()
        {
            if (_process != null && !_process.HasExited)
            {
                _process.Kill();
                _process.WaitForExit();
            }
        }
    }
}
